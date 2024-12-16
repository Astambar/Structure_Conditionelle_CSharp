string input_users(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine();
}
int input_users_int(string message)
{
    return int.Parse(input_users(message));
}
double input_users_double(string message)
{
    return double.Parse(input_users(message));
}

void TaTaillePasDispoDisponible()
{
    List<int> tailles = [];
    List<double> poids = [];
    string temp_taille_input;
    string temp_poids_input;
    int? temp_taille_int;
    int? temp_poids_int;
    while (true)
    {
        temp_taille_int = null;
        temp_poids_int = null;
        temp_taille_input = input_users("Ta Taille: ");
        if (temp_taille_input == "exit")
            break;
        temp_poids_input = input_users("Ton poids: ");
        if (temp_poids_input == "exit")
            break;

        temp_poids_int = int.Parse(temp_poids_input);
        if (temp_poids_int == 0 || temp_poids_int == null)
        {
            Console.WriteLine("Votre Poids ne peut êtres vide ou egal à 0");
            continue;
        }
        temp_taille_int = int.Parse(temp_taille_input);
        if (temp_taille_int == 0 || temp_taille_int == null);
        {
            Console.WriteLine("Votre Tailles ne peut êtres vide ou egal à 0");
            continue;
        }

    }
}

Console.WriteLine();
