function linkMono()
	libdirs {[[C:\Program Files\Mono\lib]]}
end

project "lumixengine_csharp"
	libType()
	files { 
		"src/**.c",
		"src/**.cpp",
		"src/**.h",
		"genie.lua"
	}
	includedirs { "../lumixengine_csharp/src", [[C:\Program Files\Mono\include\mono-2.0]] }
	linkMono()
	buildoptions { "/wd4267", "/wd4244" }
	defines { "BUILDING_CSHARP" }
	links { "engine" }
	useLua()
	defaultConfigurations()
	
	
table.insert(build_app_callbacks, linkMono)
table.insert(build_studio_callbacks, linkMono)