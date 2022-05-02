namespace Flyerify.Models
{
    public class TemplateModel
    {
        public int id {get; private set;}
        public string imagePath {get; private set;}
        public string title {get; private set;}
        public string theme {get; private set;}
        public string description {get; private set;}

        public TemplateModel(int id, string imagePath, string title, string theme, string description){
            this.id = id;
            this.imagePath = imagePath;
            this.title = title;
            this.theme = theme;
            this.description = description;
        }
    }
}