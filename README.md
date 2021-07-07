# Dependency Injection Patterns
## Overview
Demonstrates some C# dependency injection patterns in .Net Core with a side order of how to implement the decorator pattern

1. Unscoped DI - demonstrates how to add functionality to a base class, firstly by direct inheritance then by using the decorator pattern
1. Scoped DI - demonstrates how to register multiple implementations of an interface and for a consuming class to choose which one to use
1. Capbability DI - demonstrates how to register multiple implementations of an interface and for a consuming class to iterate through them all while getting them to decide which ones should handle the data passed to them