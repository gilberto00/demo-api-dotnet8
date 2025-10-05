# 🚀 Demo API — .NET 8 (Minimal API, Validation, JSON)

Petit projet **.NET 8 (C#)** illustrant la création d’une **API REST minimaliste**, avec :
- Des endpoints GET paramétrés ;
- Des retours JSON structurés ;
- La validation d’entrées et le traitement d’erreurs ;
- Des statuts HTTP appropriés (`200`, `400`).

---

## 🎯 Objectif

Ce projet démontre comment construire une **Minimal API** claire et maintenable en utilisant les bonnes pratiques de développement .NET 8.

Il s’agit d’un exemple d’API légère qui peut servir de base pour explorer :
- La **structure RESTful**,
- La **validation d’entrées**,
- Le **traitement des exceptions**,
- Et le **retour de données JSON** typé.

---

## 🧱 Endpoints disponibles

### 🔹 1. `GET /api/hello`

Renvoie un message de bienvenue et la date courante.

**Exemple de requête :**

GET http://localhost:5041/api/hello


**Exemple de réponse :**
{
  "message": "Bonjour depuis votre API .NET 8 🚀",
  "date": "2025-10-04T21:00:00"
}


🔹 2. GET /api/math/square/{number} 
Calcule le carré d’un nombre transmis dans l’URL.

Exemple de requête :

GET http://localhost:5041/api/math/square/5


Réponse :
{
  "number": 5,
  "result": 25,
  "message": "Le carré de 5 est 25"
}


Cas d’erreur :

GET http://localhost:5041/api/math/square/-3


Réponse :
{
  "error": "Le nombre ne peut pas être négatif."
}


🧠 Le projet gère les erreurs d’entrée en renvoyant un 400 Bad Request avec un message JSON clair.

⚙️ Technologies utilisées
Composant	Description
.NET 8	Framework moderne pour le développement Web
C#	Langage principal
Minimal API	Style léger et rapide pour créer des endpoints
HTTP Status Codes	Utilisation correcte des codes 200 et 400
JSON	Format d’échange standard pour les réponses
🧪 Exécution locale
1️⃣ Cloner le dépôt

git clone https://github.com/gilberto00/demo-api-dotnet8.git
cd demo-api-dotnet8

2️⃣ Exécuter l’application
dotnet run

Une fois lancée, l’API sera accessible à :

http://localhost:5041

🧠 Points techniques démontrés

✅ Utilisation des top-level statements (.NET 8)
✅ Endpoints REST clairs et documentés
✅ Validation d’entrées et gestion d’erreurs
✅ Statuts HTTP explicites (200 / 400)
✅ Retour JSON propre et lisible

💬 Exemple d’utilisation

Depuis le terminal :

curl http://localhost:5041/api/math/square/9

Sortie :

{
  "number": 9,
  "result": 81,
  "message": "Le carré de 9 est 81"
}

🧠 Auteur

👤 Gilberto Couto Pereira Rosa
📍 Saint-Roch-de-Richelieu, QC
📧 gilberto00@gmail.com

🔗 LinkedIn

💡 Idée pour extension

Prochaines étapes possibles :

Ajouter un endpoint POST pour recevoir un JSON en entrée ;

Intégrer un logging structuré (ILogger) ;

Ajouter un middleware global de gestion d’erreurs ;

Documenter l’API via Swagger/OpenAPI.
