# Dependency Injection Patterns
## Overview
Demonstrates some C# dependency injection patterns in .Net Core with a side order of how to implement the decorator pattern

1. Unscoped DI - demonstrates how to add functionality to a base class, firstly by direct inheritance then by using the decorator pattern
1. Scoped DI - demonstrates how to register multiple implementations of an interface and for a consuming class to choose which one to use
1. Capbability DI - demonstrates how to register multiple implementations of an interface and for a consuming class to iterate through them all while getting them to decide which ones should handle the data passed to them

## Instructions
The Program.cs file contains all the dependency injection code.  When initially cloned, Program.cs is set up to demonstrate the Unscoped DI direct inheritance example (which has a deliberate bug in it to do with new/virtual/override).  You can comment/uncomment the various regions in the Program.cs file to move through the other demos.  

The unscoped DI demo has various sub-regions, the first for the direct inheritance demo and the second for the chained (decorator pattern) classes.  Each of these can be commented/uncommented in turn.

The scoped DI demo has its own single region - again, comment out the other regions and uncomment this region.

The capability DI demo has its own single region - again, comment out the other regions and uncomment this region.
