# Nuclei.ExceptionHandling


## FusionHelper

The `TopLevelExceptionGuard` class provides a single method that can serve as a top level exception handler. In order to use this handler
one or more exception processor classes have to be defined. 

[!code-csharp[TestExceptionProcessor](..\..\Nuclei.ExceptionHandling.Samples\TestExceptionProcessor.cs?range=13-37)]

With the exception processors defined the `TopLevelExceptionGuard.RunGuarded` method can be invoked.

[!code-csharp[TopLevelExceptionGuard.RunGuarded](..\..\Nuclei.ExceptionHandling.Samples\TopLevelExceptionGuardSample.cs?range=23-33)]
