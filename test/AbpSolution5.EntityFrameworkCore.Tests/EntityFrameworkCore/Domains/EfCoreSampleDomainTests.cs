using AbpSolution5.Samples;
using Xunit;

namespace AbpSolution5.EntityFrameworkCore.Domains;

[Collection(AbpSolution5TestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<AbpSolution5EntityFrameworkCoreTestModule>
{

}
