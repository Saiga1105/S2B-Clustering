# Scan-to-BIM Clustering repository

This toolbox includes functions for the clustering of wall geometry.
It contains the training and testing of Conditional Random Fields for the grouping of wall mesh segments based on a number of descriptors.
The sample files contain some example wall segment descriptors.

### contribute
There are several large files in this repository (matlab .dll's and sample files)
Use github's Large File System (lfs) to push changes to the origin.

1) make sure the .dll files are tracked after commiting
	git lfs track '*.dll'
	git lfs track '*.mat'

### license 
If you use this software in a publication, please cite the work using the following information:

Bassier M., Vergauwen M. (2019) Clustering of Wall Geometry from Unstructured Point Clouds Using Conditional Random Fields. 
Remote Sensing, 11(13), 1586; https://doi.org/10.3390/rs11131586

### dependencies
M. Schmidt. UGM: A Matlab toolbox for probabilistic undirected graphical models. http://www.cs.ubc.ca/~schmidtm/Software/UGM.html, 2007.
Verify that version 9.4 (R2018a) of the MATLAB Runtime is installed.
You can download it at http://www.mathworks.com/products/compiler/mcr/index.html

