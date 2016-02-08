\ see test.h and test.c files
\ The following are the command line commands to make the libary
\ gcc -c -fPIC test.c -o test.o
\ ar rcs libtest.a test.o
\ gcc -shared -Wl,-soname,libtest.so.1 -o libtest.so.1.0.1 test.o
\ sudo cp libtest.so.1.0.1 /usr/lib
\ sudo ln -sf  libtest.so.1.0.1 /usr/lib/libtest.so
\ sudo ln -sf /usr/lib/libtest.so.1.0.1 /usr/lib/libtest.so.1
\ sudo ldconfig -n /usr/lib/

c-library mycfunction		  \ note this is simply a file name for this linking process
s" test" add-lib		  \ now use the shared library
c-function seemytest mytest -- n  \ the -- is needed and indicates to forth how to handle
\ the data type returned from the c function.  In this case n means basic interger.
\ Look at the gforth documentation for other data types.
end-c-library
\ Now you can use the function as follows:
\ seemytest .
