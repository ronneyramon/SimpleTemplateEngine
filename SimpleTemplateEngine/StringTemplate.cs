using System;

namespace SimpleTemplateEngine
{
    public class StringTemplate
    {
        private string _template;

        public StringTemplate(string template)
        {
            _template = template;
        }

        public string Apply(object model)
        {
            return _template;
        }
    }
}
