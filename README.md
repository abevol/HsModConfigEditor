# HsMod Config Editor

编写了一个空白游戏用于模拟加载 [HsMod] 和 [BepInExConfigManager]，以对 [HsMod] 的配置文件进行可视化编辑。

*本仓库中的 `HsMod` 源码已剥离了多余代码，仅保留了配置相关内容。*

注：

1. 这只是一个缓解方案，需要一定的动手能力，如想安逸请等待 `HsMod` 作者更新。
2. 修改配置需要重启游戏才会生效。

## 使用说明

1. 从 [Releases] 下载 `HsModConfigEditor.7z`，并解压缩，执行 `HsModConfigEditor.exe`。
2. 进入全屏程序后，按 F5 键即可打开配置菜单。
3. 初次运行时，程序会将 `HsMod.cfg` 的语言选项 `HsMod.Init.Language` 设置为当前系统语言。
4. 如果你想修改为其它语言，请在菜单中选择（或者手动编辑 `HsMod.cfg`），然后重新运行 `HsModConfigEditor.exe`。
5. 将修改后的配置文件 `HsMod.cfg` 复制到游戏目录下的 `BepInEx\config` 文件夹内。
6. 或者通过 `mklink` 创建一个配置文件 `HsMod.cfg` 的符号链接，免去手动复制之苦。
7. 命令示例：`mklink "D:\GameTools\HsModConfigEditor\BepInEx\config\HsMod.cfg" "D:\NetGame\Hearthstone\BepInEx\config\HsMod.cfg"`

## 截屏预览

![Preview](https://github.com/abevol/HsModConfigEditor/blob/master/Preview.png?raw=true)

## 版权声明

所有相关版权归原作者所有。

[HsMod]: https://github.com/Pik-4/HsMod
[BepInExConfigManager]: https://github.com/sinai-dev/BepInExConfigManager
[Releases]: https://github.com/abevol/HsModConfigEditor/releases
