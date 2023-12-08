using PetStore;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

PetStoreClient client = new PetStoreClient(null);

client.Pet.FindByStatus.GetAsync