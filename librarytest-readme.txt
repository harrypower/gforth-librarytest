See librarytest.h and librarytest.c files as these are the c files to make the test library.
The following are the command line commands to make the libary test stuff in this folder

gcc -c -fPIC librarytest.c -o librarytest.o
  \ This compiles the c files into an object called librarytest.o but is position independent.
ar rcs liblibrarytest.a librarytest.o
  \ This makes the object in to an archive with all the information in it for use later.
gcc -shared -Wl,-soname,liblibrarytest.so.1 -o liblibrarytest.so.1.0.1 librarytest.o
  \ This makes the shared library from the files created in the last two steps.
sudo cp liblibrarytest.so.1.0.1 /usr/lib
  \ This places the shared library into the location it is used in the debian system
sudo ln -sf  liblibrarytest.so.1.0.1 /usr/lib/liblibrarytest.so
  \ This makes a symbolic link to the shared library
sudo ln -sf /usr/lib/liblibrarytest.so.1.0.1 /usr/lib/liblibrarytest.so.1
  \ This makes another symbolic link to the shared library with the main version number only
sudo ldconfig -n /usr/lib/
  \ This tells the debian system to reconfigure all the shared librarys in the library folder
