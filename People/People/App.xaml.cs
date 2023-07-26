namespace People;

public partial class App : Application
{
    public static PersonRepository PersonRepo { get; private set; }

    public App(PersonRepository repo)
	{
		InitializeComponent();

		MainPage = new AppShell();

        // TODO: Initialize the PersonRepository property with the PersonRespository singleton object
        // Inicializa la propiedad PersonRepository con el objeto singleton PersonRepository.
        PersonRepo = repo;
	}
}
