# title

some explenation

### Use
There are several large files in this repository (matlab .dll's and sample files)
Use github's Large File System (lfs) to push changes to the origin.

1) make sure the .dll files are tracked after commiting
	git lfs track '*.dll'
	git lfs track '*.mat'

2) push large files to fls storage
	git lfs push --all origin master
	
3) push pointers to github
	git push -u origin master
	
2) commit and push changes
	git add .
	git commit -m 'add new large files'
	git push (git push --set-upstream origin master if origin isn't upstream yet)
 
### license 
mention my stuff

### dependencies
M. Schmidt. UGM: A Matlab toolbox for probabilistic undirected graphical models. http://www.cs.ubc.ca/~schmidtm/Software/UGM.html, 2007.
Verify that version 9.4 (R2018a) of the MATLAB Runtime is installed.
You can download it at http://www.mathworks.com/products/compiler/mcr/index.html

