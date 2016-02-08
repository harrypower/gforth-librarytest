See librarytest.h and librarytest.c files as these are the c files to make the test library.
The following are the command line commands to make the libary test stuff in this folder

gcc -c -fPIC test.c -o test.o
  \ This compiles the c files into an object called librarytest.o but is position independent.
ar rcs libtest.a test.o
  \ This makes the object in to an archive with all the information in it for use later.
  \ not the 'lib' is added to the name and the extention is changed to .a 
gcc -shared -Wl,-soname,libtest.so.1 -o libtest.so.1.0.1 test.o
  \ This makes the shared library from the files created in the last two steps.
sudo cp libtest.so.1.0.1 /usr/lib
  \ This places the shared library into the location it is used in the debian system
sudo ln -sf  libtest.so.1.0.1 /usr/lib/libtest.so
  \ This makes a symbolic link to the shared library
sudo ln -sf /usr/lib/libtest.so.1.0.1 /usr/lib/libtest.so.1
  \ This makes another symbolic link to the shared library with the main version number only
sudo ldconfig -n /usr/lib/
  \ This tells the debian system to reconfigure all the shared librarys in the library folder


gcc testing.c -ltest -o myctest.exe
  \ This is how you would link to the shared library in a c code.
  \ Note the -ltest is the name of the shared library were test is the real name and l is the message 
  \ to the compiler that you are linking to a shared library. 
./myctest.exe
  \ this is the way you run your new c compiled executable at command line.
