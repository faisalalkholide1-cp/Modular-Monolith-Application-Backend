using AbpSolution5.Samples;
using Xunit;

namespace AbpSolution5.EntityFrameworkCore.Applications;

[Collection(AbpSolution5TestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<AbpSolution5EntityFrameworkCoreTestModule>
{

}
