
# OpenTK

The Open Toolkit is a low-level .NET library written in C# that wraps OpenGL and OpenAL.

This is a fork of the official project at http://www.opentk.com

# The Column branch

This brach contain major differces to the original OpenTK project.

 * Matrices are stored column-major
 * Generated Matrix transforms assume column vectors
 * Generated perspective projection look down the -z axis
 * Deprecated OpenGL (since 3.1) functions are removed
 * GameWindow removed, instead we use separate GLControl(Windows) and GLWidget(GTK) for graphics only
 * Obsolete OpenTK Methods removed
 * Major overhaul of Matrix and Vector methods

