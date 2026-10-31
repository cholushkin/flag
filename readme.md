# Flag

## 📥 Installation (UPM / Git URL)

In Unity: **Window → Package Manager → + → Install package from git URL…**

```
https://github.com/cholushkin/flag.git
```

No manual Git dependencies are required — `Runtime/` has no dependency on
any other package.

## 📦 What this package is

A pure UPM package: three `MonoBehaviour` utilities in `Runtime/` (`Rotate`,
`ColorPropertyOverride`, `TexturePropertyOverride`) for driving a flag-waving
shader effect via `MaterialPropertyBlock`.

A worked example — the flag FBX models, URP shadergraph materials, prefabs
and a sample scene — ships as an installable **Sample** rather than inside
the package itself: open **Window → Package Manager → Flag → Samples**, and
click **Import** next to **Flag Demo**. `Documentation/` (README images) is
the only other thing at the repo root; everything else needed to *use* the
package lives in `Runtime/` and `Samples~/FlagDemo/`.

The original Blender source, Python export tooling, and standalone sandbox
Unity project this package was extracted from are not part of this repo —
see the shader effect itself below.

## Shader Graph implementation

* `LitFlag`: A simple lit shader using a color tint
* `LitFlagTexture`: A version that combines texture sampling with color tinting

Both ship with the **Flag Demo** sample (see above) alongside the models,
prefabs and scene that showcase them.

## Features

* 🚩 **No cloth simulation** — uses a lightweight shader-based waving effect (faster and more GPU-friendly)
* 🧭 **Works in object space** — the flag animation remains consistent even when the object is rotated
* 🎨 **Color and Texture support via `MaterialPropertyBlock`** — allows dynamic per-object coloring & texturing without duplicating materials (ideal for batching and memory efficiency)


![Flag Animation](Documentation/Animation.gif)
![Screenshot](Documentation/Screenshot_1.jpg)


## Tags

Unity Shader Graph, Flag Shader, Shader Animation, MaterialPropertyBlock, Unity Export Blender, Blender to Unity, GPU Efficient Animation, Unity Object Space, Unity Shader Demo, Unity Procedural Animation, Lightweight Shader, Unity Tint Texture, Unity Shader Graph Texture Color, Unity Shader Graph Flag
