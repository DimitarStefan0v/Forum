namespace ForumApp.Web.ViewModels.SubCategories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SubCategoryInputModel
    {
        public string Title { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int CategoryId { get; set; }
    }
}
