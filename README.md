# TestOverIt

MAUI Flickr Photo Search

📌 Descrizione

Questa applicazione .NET MAUI consente agli utenti di cercare foto su Flickr utilizzando le Flickr API. Le immagini vengono visualizzate in una CollectionView con infinite scroll, e cliccando su un'immagine si aprirà una schermata con i dettagli della foto.

📦 Requisiti

.NET 9

.NET MAUI workload installato

Visual Studio 2022 (consigliato)

🚀 Configurazione e Build

1️⃣ Installare .NET MAUI Workload

Se non hai già installato .NET MAUI, esegui da prompt:

 dotnet workload install maui

2️⃣ Clonare il Repository

git clone <URL_REPOSITORY>
cd MauiFlickrApp

3️⃣ Compilare ed eseguire l’app

🔹 Da Visual Studio

Aprire il file MauiFlickrApp.sln in Visual Studio 2022

Selezionare la configurazione Debug o Release

Scegliere il dispositivo/emulatore e avviare l'app

🔹 Da riga di comando

Per Android:

dotnet build -t:Run -f net9.0-android

Per Windows:

dotnet build -t:Run -f net9.0-windows10.0.19041.0

📡 Dipendenze Utilizzate

CommunityToolkit.Mvvm → Per il pattern MVVM e RelayCommand

Newtonsoft.Json → Per la deserializzazione JSON

🔑 API Key

L'API Key è già inclusa nel file di configurazione:

key: 255ac8fdac4726aa339fa1c2161b9e5b
secret: c2c1dbb234cd7d15

⚠ Attenzione: Se l’API Key scade, puoi ottenerne una nuova su Flickr API

📱 Funzionalità dell’App

✅ Ricerca di immagini tramite parola chiave
✅ Visualizzazione delle immagini in infinite scroll
✅ Clic su un'immagine per vedere i dettagli
✅ UX ottimizzata con una ContentView personalizzata

🔧 Possibili Miglioramenti

🔹 Implementare il caching delle immagini
🔹 Supporto a temi chiaro/scuro
🔹 Animazioni per migliorare l’esperienza utente

👨‍💻 Autore

Alberto Fagni - albertofagni@gmail.com
