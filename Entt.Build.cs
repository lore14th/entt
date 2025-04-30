// Entt Tinfoil build script

using Sharpmake;
using System;
using System.Collections.Generic;
using System.IO;

[Sharpmake.Generate]
public class Entt : TinfoilProjectBase
{
	public Entt()
	{
		Name = "Entt";
		SourceRootPath = @"[project.SharpmakeCsPath]/single_include";
		AdditionalSourceRootPaths.Add();
		SourceFiles.Add(@"[project.SharpmakeCsPath]/Entt.Build.cs");

		NatvisFiles.Add(@"../natvis/config.natvis");
		NatvisFiles.Add(@"../natvis/container.natvis");
		NatvisFiles.Add(@"../natvis/core.natvis");
		NatvisFiles.Add(@"../natvis/entity.natvis");
		NatvisFiles.Add(@"../natvis/graph.natvis");
		NatvisFiles.Add(@"../natvis/locator.natvis");
		NatvisFiles.Add(@"../natvis/meta.natvis");
		NatvisFiles.Add(@"../natvis/poly.natvis");
		NatvisFiles.Add(@"../natvis/process.natvis");
		NatvisFiles.Add(@"../natvis/resource.natvis");
		NatvisFiles.Add(@"../natvis/signal.natvis");
	}

	[Sharpmake.Configure]
	public void ConfigureAll(Project.Configuration config, TinfoilTarget target)
	{
		config.Output = Configuration.OutputType.Utility;

		config.Options.Add(Options.Vc.Compiler.CppLanguageStandard.CPP17);
		config.Options.Add(Options.Vc.General.WindowsTargetPlatformVersion.Latest);
		config.Options.Add(Options.Vc.Librarian.TreatLibWarningAsErrors.Enable);

		config.IncludePaths.Add(@"[project.SharpmakeCsPath]/single_include");
	}
}
