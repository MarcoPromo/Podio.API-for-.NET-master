﻿using Podio.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Podio.API.Utils.ItemFields
{
    public class CategoryItemField : ItemField
    {
        private List<Answer> _answers;

        public IEnumerable<Answer> Answers
        {
            get
            {
                return this.valuesAs<Answer>(_answers);
            }
        }

        [DataContract]
        public class Answer {

            [DataMember(Name = "status", IsRequired = false)]
            public string Status { get; set; }

            [DataMember(Name = "text", IsRequired = false)]
            public string Text { get; set; }

            [DataMember(Name = "id", IsRequired = false)]
            public int? Id { get; set; }

            [DataMember(Name = "color", IsRequired = false)]
            public string Color { get; set; }
        }

        public int OptionId {
            set
            {
                ensureValuesInitialized(true);
                this.Values.First()["value"] = value;
            }
        }

        public IEnumerable<int> OptionIds
        {
            set
            {
                ensureValuesInitialized();
                foreach (var optionId in value)
                {
                    var dict = new Dictionary<string, object>();
                    dict["value"] = optionId;
                    this.Values.Add(dict);
                }
            }
            /*
            set
            {

                ensureValuesInitialized(true);
                this.Values.First()["value"] = value;
            }
            */
        }
    }
}
