# Changelog

All notable changes to this package will be documented in this file.

## [Unreleased]
### Removed
- Deleted the standalone `Unity/Flag/` sandbox project entirely (`ProjectSettings/`, `Packages/manifest.json` + lock, and `Assets/Settings/` — including `Mobile_RPAsset.asset` and `PC_RPAsset.asset`). This repo is now a pure UPM package; the flag-shader demo is only available as an installable Sample.
- Removed `ArtSources/` (Blender source) and `UserScripts/` (Python export tooling), and deinitialized the `ScriptUtils` git submodule — none of it is needed to install or use the package.
### Changed
- Moved `SampleSceneProfile.asset` (referenced by the demo scene) into `Samples~/FlagDemo/Settings/`, since its source location no longer exists.
- `.gitignore` replaced the old `/Unity/Flag/*`-scoped entries with the standard generic Unity-package ignore set (`*.csproj`, `*.sln`, `Library/`, etc.).

## [1.0.0] - 2026-10-30

### Changed
- Converted to a Unity Package Manager (UPM) package installable via Git URL.
- Moved `Unity/Flag/Assets/Scripts/*.cs` → `Runtime/` and added a new `Flag.asmdef`
  (no assembly definition previously existed for this project).
- Moved demo FBX models, materials, prefabs, scene and textures from
  `Unity/Flag/Assets/{Fbx,Materials,Prefabs,Scenes,Textures}` → `Samples~/FlagDemo/`.
- Added `package.json` (`com.qcat.flag`), this changelog, and a license file.

No public API, behavior or namespaces were changed (none of the 3 scripts used a namespace).
