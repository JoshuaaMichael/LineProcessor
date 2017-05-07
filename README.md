# LineProcessor
</br>
Meat of the logic is in the library. It takes an input file and runs a given method over it, producing a processed line which is written to the output file.</br>
So in the library is the logic, then in the test program I implement a class which inherits from the abstract parent for processing lines for use in a Project Euler problem</br>
The problem the code solved this time was I needed to change 20 lines of 20 numbers each into an array in code. Instead of doing it manually I just dumped the data in input.txt and ran a method over it.</br>
</br>
This is probably my most re-referenced code I've ever written.</br>
Isn't any special or fancy, but it has saved me a huge amount of manual labor in many situtations.</br>
</br>
I've used it previously to run over around billion lines of data, primarily to strip out usful info (Text netflow data for those interested)</br>
Instead of reading the whole file in at once, it streams the file through, and streams into the output text file (buffers a set number of lines at a time to not waste IO)</br>
Reading the file line by line allows me to load those massive 500MB text files from Netflow</br>
</br>