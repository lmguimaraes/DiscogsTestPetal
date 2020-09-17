# DiscogsTestPetal
Bonjour,

Comme décrit dans le texte explicatif du test, j'ai créé une application qui consomme l'API fourni et expose une méthode pour obtenir quelques objets de la collection aléatoirement. Pour le faire je me suis servi du template .NET Core MVC disponible sur Visual Studio 2019. Il a deux façons de tester l’API :
1-	Exécuter le projet et saisir un numéro sur l’écran que s’affiche. Le retour sera sur l’écran sans traitement (string JSON qui contient le numéro d’objets désirés).
2-	Sans interface graphique, il suffit d’exécuter le projet et utiliser n’importe quel logiciel pour appeler l’API avec le format suivant : 
http://{ l’adresse du hôte}/Collection/GetCollection/{quantité}
Il faut remplacer l’adresse de l’hôte par votre adresse et la quantité par le numéro désire. Le résultat final rassemble à cela: http://localhost:3728/Collection/GetCollection/4
Comme il n’y a pas d’intégration, il n’y a pas de tests pour les routes et méthodes intégrées. Aussi, comme il s’agit d’un test où l’entrée de l’usager est attendue je n’ai pas ajouté des validations extensives sur les possibilités d’entrée.
