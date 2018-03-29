# VR_HapticEngine(Required Unity SteamVR Plugin)

## To use

### HapticClipの作成
Projectビューで右クリック→Haptic/HapticClipでNewHapticClipを作成

### HapticClipの再生
SteamVR_TrackedObjectがアタッチされたGameObjectにHapticListenerをアタッチ<br>
適当なオブジェクトにHapticSourceをアタッチ<br>
HapticSourceに再生したいClipと振動させたいデバイスのHapticListenerをアタッチ<br>
HapticSource.Play(); で再生