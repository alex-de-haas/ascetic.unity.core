# Ascetic's Unity Core

Core package for Unity. Contains editor improvements and common functionality for other packages.

## Installation

**Ascetic's Unity Core** is used through **Unity's Package Manager**. In order to use it you'll need to add the following lines to your `Packages/manifest.json` file. This has to be done so your Unity editor can connect to NPM's package registry.

```
"scopedRegistries": [
  {
    "name": "NPM",
    "url": "https://registry.npmjs.org",
    "scopes": [
      "com.fluid"
    ]
  }
]
```

After that you'll be able to visually control what specific version of **Ascetic's Unity Core** you're using from the package manager window in Unity.

From Unity IDE: Window -> Package Manager
* Click "+" -> Add package from git URL
* Enter "ascetic.unity.core"
* Click "Add"

Enjoy!