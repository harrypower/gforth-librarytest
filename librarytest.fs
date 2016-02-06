\ see librarytest.h and librarytest.c files
\ The following are the command line commands to make the libary
\ gcc -c -fPIC librarytest.c -o librarytest.o
\ ar rcs liblibrarytest.a librarytest.o
\ gcc -shared -Wl,-soname,liblibrarytest.so.1 -o liblibrarytest.so.1.0.1 librarytest.o
\ sudo cp liblibrarytest.so.1.0.1 /usr/lib
\ sudo ln -sf  liblibrarytest.so.1.0.1 /usr/lib/liblibrarytest.so
\ sudo ln -sf /usr/lib/liblibrarytest.so.1.0.1 /usr/lib/liblibrarytest.so.1
\ sudo ldconfig -n /usr/lib/

c-library mycfunction		\ note this is simply a file name for this linking process
s" librarytest" add-lib		\ now use the shared library
c-function seemytest mytest -- n	 \ the -- is needed and indicates to forth how to handle  the data type returned from the c function.  In this case n means basic interger.  Look at the gforth documentation for other data types.
end-c-library
\ Now you can use the function as follows:
\ seemytest .
