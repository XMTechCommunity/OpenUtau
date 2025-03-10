using System.Collections.Generic;
using OpenUtau.Api;

namespace OpenUtau.Core.DiffSinger {

    [Phonemizer("DiffSinger Wu Phonemizer", "DIFFS WUU", language: "WUU")]
    public class DiffSingerWuPhonemizer : DiffSingerBasePhonemizer {
        protected override string GetDictionaryName() => "dsdict-wuu.yaml";
        protected override string GetLangCode() => "wuu";
        }
    }
}