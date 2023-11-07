using System.Collections.Generic;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace NpcProtector.Settings
{

    public class Settings
    {
        public List<IFormLinkGetter<INpcGetter>> NpcsToProtect { get; set; } = new();
    }
}