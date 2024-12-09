namespace SoftwareDesignFinal
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IRecipeManager recipeManager = new LoggingRecipeManagerDecorator(new RecipeManager());
            Application.Run(new Form1(recipeManager));
        }
    }
}