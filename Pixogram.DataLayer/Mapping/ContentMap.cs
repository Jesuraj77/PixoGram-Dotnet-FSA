using FluentNHibernate.Mapping;
using Pixogram.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pixogram.DataLayer.Mapping
{
    public class ContentMap : ClassMap<Content>
    {
        public ContentMap()
        {

            Id(x => x.Id);

            Map(x => x.Image);

            Map(x => x.Video);
            Map(x => x.Caption);
            Map(x => x.Description);
            Map(x => x.Visibility);
            Map(x => x.UserId);

            Table("Content");

        }
    }
}
