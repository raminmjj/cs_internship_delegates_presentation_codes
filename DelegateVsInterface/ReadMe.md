# Delegates vs Interfaces

|Aspect|Delegates|Interfaces|
|---|---|---|
|**Purpose**|Pass methods as parameters and manage groups of methods (event handling, callbacks)|Define contracts with methods, properties, and events|
|**Method Chaining**|Can chain multiple methods together|Not supported|
|**Inheritance**|Not supported|Supports inheritance|
|**Multiple Behaviors**|Not supported|Can implement multiple behaviors in a class or struct|
|**Type**|Defines method signature, holds method reference|Contract containing method, property, and event declarations|
|**Usage Scenario**|Event handling, callbacks|Defining a set of related methods and properties for classes or structs to implement|
|**Extensibility**|Can be extended with multicast delegates|Can be extended with inheritance|
|**Variance**|Supports covariance and contravariance|Does not support variance|