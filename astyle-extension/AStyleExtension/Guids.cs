// Guids.cs
// MUST match guids.h

using System;

namespace AStyleExtension {
    static class GuidList {
        public const string GuidPkgString = "6b52ccde-8ae4-4233-bccd-6b9b0ba06a56";
        public const string GuidCmdSetString = "b507eff0-0667-4d9c-865f-37557da05594";

        public static readonly Guid GuidCmdSet = new Guid(GuidCmdSetString);
    };
}