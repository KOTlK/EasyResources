## EasyResources
**Package for self use, that provides easy access to resources.**

## Warnings
Package created for fun and to learn how to create packages. **DO NOT USE IT**

## Installation

 1. Import package to Unity, using *Assets -> Import Package -> Custom Package...*
 2. Press *EasySpawning -> Window -> Set your path to Resources folder -> Press **Save***  It saves all your Resources to file inside *Resources/EasySpawning* folder. **Warning: if two or more files have same name, they can't be recognized as separate files and you won't be able to initialize Main Class. I'm too lazy to fix it.**
 3. Initialize EasyResources by importing namespace **EasyResources** and initializing Main Class by `new EasySpawning()`
 4. Use package by calling static methods from EasySpawning.

## Usage
### EasySpawning
#### Description:
Main class. Provides loading of resources.
#### Static methods:
| `public static bool TryLoadResource<T>(string name, out T resource)` | Returns true if able to load resource with name "**name**" and sets it to "**resource**" variable. Just like default `Resources.Load` |
|--|--|
| `public static T InstantiateResource<T>(string name)` and it's overloads | Loads resource with specified name and instantiate it. Has same overloads as `UnityEnine.Object.Instantiate` method. | 
