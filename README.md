# MusicPlaysInHideout
[Mod page.](https://hub.sp-tarkov.com/files/file/2891-music-plays-in-hideout)

Downloads:
- [For 4.0.x](https://github.com/Mugnum/SPT_MusicPlaysInHideout/releases) (latest)
- [For 3.11.x](https://github.com/Mugnum/SPT_MusicPlaysInHideout/releases/tag/1.1.0)
- [For 3.10.x](https://github.com/Mugnum/SPT_MusicPlaysInHideout/releases/tag/1.0.0)

# Build instructions for new versions
1. Clear existing assembly references.
2. Create "Dependencies" folder and copy into it following files:
   - BepInEx\core\BepInEx.dll
   - BepInEx\plugins\spt\spt-reflection.dll
   - EscapeFromTarkov_Data\Managed\Assembly-CSharp.dll
   - EscapeFromTarkov_Data\Managed\DOTween.dll
   - EscapeFromTarkov_Data\Managed\DOTween.Modules.dll
   - EscapeFromTarkov_Data\Managed\UnityEngine.dll
   - EscapeFromTarkov_Data\Managed\UnityEngine.AudioModule.dll
   - EscapeFromTarkov_Data\Managed\UnityEngine.CoreModule.dll
   - EscapeFromTarkov_Data\Managed\UnityEngine.UI.dll
   - EscapeFromTarkov_Data\Managed\UnityEngine.UIModule.dll
3. Add references to project and compile "Release" build.
4. Resolve names for obfuscated methods if necessary (method_9, etc).
5. Copy resulting .dll file from \bin\Release\ to \BepInEx\plugins\
