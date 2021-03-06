﻿namespace Slack.NetStandard
{
    public class MarkdownText : TextObject
    {
        public MarkdownText() { }

        public MarkdownText(string text) : base(text) { }
        public override TextType Type => TextType.Markdown;
    }
}