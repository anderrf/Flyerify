using Flyerify.Models;

namespace Flyerify.Repositories
{
    public interface ITemplateRepository
    {
        List<TemplateModel> getTemplates();
        TemplateModel getTemplateById(int id);
    }

    public class TemplateRepository : ITemplateRepository
    {
        public List<TemplateModel> getTemplates()
        {
            return this.setTemplatesList();
        }

        public TemplateModel getTemplateById(int id)
        {
            return (TemplateModel)this.setTemplatesList()
                .Where<TemplateModel>(template => template.id == id)
                .First();
        }

        public List<TemplateModel> setTemplatesList(){
            List<TemplateModel> templates = new List<TemplateModel>();
            templates.Add(new TemplateModel(
                1,
                "/assets/images/template1.png",
                "TideFarer",
                "Viagens de cruzeiro",
                "Experiência em viagens nacionais e internacionais."
            ));
            templates.Add(
                new TemplateModel(
                2,
                "/assets/images/template2.png",
                "Scald",
                "Cafeteria",
                "Atração de clientes em potencial para saborear café."
            )
            );
            return templates;
        }
    }

}