copy antlr_output VKScript\VKScript\VkScript\Antlr\
MSBuild VKScript\VKScript.sln /t:Build /p:Configuration=Release /p:TargetFramework=v4.5
