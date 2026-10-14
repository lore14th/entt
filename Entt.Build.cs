// Tinfoil Engine build script

using Sharpmake;
using System.IO;
using TinfoilBuildTool;

using Configuration = Sharpmake.Project.Configuration;

[BuildModule(typeof(TinfoilProject))]
public class Entt : TinfoilThirdPartyModuleDependency
{
	public Entt(ReadOnlyModuleRules rules) : base(rules)
	{
	}

	public override void InitializeModuleBuildProject(Project project)
	{
		base.InitializeModuleBuildProject(project);

		project.SourceRootPath = Path.Combine("[project.SharpmakeCsPath]", "single_include");
		project.NatvisFiles.AddRange(Directory.EnumerateFiles(Path.Combine(RootDirectory, "natvis")));
	}

	public override void ConfigureBuild(Configuration config, ITarget target)
	{
		base.ConfigureBuild(config, target);
		config.Output = Configuration.OutputType.Utility;

		config.IncludePaths.Add(Path.Combine("[project.SharpmakeCsPath]", "single_include"));
	}
}
