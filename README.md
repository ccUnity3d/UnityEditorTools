﻿# UnityEditorTools
整理一些常用的工具，以及一些简单的实例工程，不定期更新    

##################################################################################
#2017-03-14 更新 
## Http方式下载Assetbundle资源包到本地磁盘，然后使用

-Http方式下载Assetbundle资源包到本地磁盘，然后使用 流程整理，Assets\Examples\TableDataPack\AbHotUpdate.unity    PC & 阿里云搭建FTP测试通过    
-WWW的加载模式，是存在cache里面的，清空应用缓存，就需要从新下载    
-关于流程的一些问题：    
	1，MD5文件需要有备份，因为热更资源包过程被打断的话，需要有备份可以还原，否则会导致一次更新出错，版本文件匹配就出错，后面无法正常更新    
	2，在是否要下载前，应该有充分的剪枝去重，比如WWW模式下，应该先查看cache，Http模式下先查看本地磁盘路径
	3，StringAssets目录是只读的，实例中只在PC编辑器环境下端验证过，这个要注意
	4，StringAssets在安卓平台，只能用WWW异步加载


##################################################################################
#2017-03-13 更新 
## 热更Assetbundle资源包 实例

-简单的热更加载流程整理，Assets\Examples\TableDataPack\AbHotUpdate.unity    PC & 阿里云搭建FTP测试通过    
-菜单栏[MenuItem("Helper/Clean Cache")]    
	协助测试用，清理本地缓存

##################################################################################
#2017-03-13 更新    
## AssetBundle打包 整理    

-Unity版本更新到Unity 5.5.0f3 (64-bit)，BuildAssetbundles(string outpath)弃用，打包工具做相应调整
 

##################################################################################
#2017-03-11 更新
## AssetBundle打包 整理       

-菜单栏[MenuItem("Helper/Table Window")]    
	Excel表格多了一步跟对应CS绑定输出ScriptObject    

-Assets\StreamingAssets 目录为各个不同标签的AB包整包输出目录，不同平台均共享这个目录，输出前会清空这个目录    
	这里是为了方便Examples演示用，所以不同平台都放在一个目录，实际开发中可以分开存放，可以避免反复切换平台需要反复打包    
	不过出包的时候需要把输出的AB包贴到游戏调用的统一目录（比如StreamingAssets）    

-内附加载表格实例（Assets\Examples\TableDataPack\TableDataPack.unity）PC，Android真机测试通过

-菜单栏[MenuItem("Helper/UITexturePack")]    
	Assets/UITexture/目录下面所有贴图资源打包    
   

-菜单栏[MenuItem("Helper/MD5Tools Window")]    
	给指定路径(示例中为StreamingAssets)下的资源生成MD5文件，用来做热更比对用    



##################################################################################
#2017-03-10 更新
## FTP文件操作整理 （未完成）

-这个工具是 Assetbundle打包热更 工作流的一部分，可以开放在打包工具界面上，方便开发人员及时热更资源包    
-内附读取指定FTP根目录文件列表实例（Assets\Examples\Ftp\FtpUpDownExample.unity）PC & 阿里云搭建FTP测试通过


##################################################################################
#2017-03-10 更新
## Excel表格打包(已更新)