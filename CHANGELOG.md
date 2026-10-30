# Changelog

All notable changes to this package will be documented in this file.

## [1.0.0] - 2026-10-30

### Changed
- Converted to a Unity Package Manager (UPM) package installable via Git URL.
- Moved `Unity/Flag/Assets/Scripts/*.cs` → `Runtime/` and added a new `Flag.asmdef`
  (no assembly definition previously existed for this project).
- Moved demo FBX models, materials, prefabs, scene and textures from
  `Unity/Flag/Assets/{Fbx,Materials,Prefabs,Scenes,Textures}` → `Samples~/FlagDemo/`.
- Added `package.json` (`com.qcat.flag`), this changelog, and a license file.

No public API, behavior or namespaces were changed (none of the 3 scripts used a namespace).
