using System.Collections.Generic;
public class Root
    {
        public int HeaderSize;
        public int HeaderCrc;
        public int MajorVersion;
        public int MinorVersion;
        public int NetVersion;
        public string GameType;
        public Properties Properties;
        public int ContentSize;
        public long ContentCrc;
        public object NetworkFrames;
        public List<string> Levels;
        public List<Keyframe> Keyframes;
        public List<object> DebugInfo;
        public List<TickMark> TickMarks;
        public List<string> Packages;
        public List<string> Objects;
        public List<string> Names;
        public List<ClassIndice> ClassIndices;
        public List<NetCache> NetCache;
    }
