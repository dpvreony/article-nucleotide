using Dhgms.Nucleotide.Generators.Features.Model;
using Dhgms.Nucleotide.Generators.Models;
using Microsoft.CodeAnalysis;

namespace Article.Nucleotide.CodeGenerator
{
    [Generator]
    public sealed class SampleUnkeyedModelInterfaceGenerator : UnkeyedModelInterfaceGenerator
    {
        protected override INucleotideGenerationModel NucleotideGenerationModel => new ModelGenerationDetails();
    }
}
