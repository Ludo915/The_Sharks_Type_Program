using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class TextInitializer: MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DataManager.Instance.TargetText = GetFunFactText("avions");
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public string GetFunFactText(string theme)
    {
        List<string> myStringList = new List<string>();

        // Thème: Mathématiques
        myStringList.Add("En mathématiques, un cercle a une infinité de côtés! Drôle, non?");
        myStringList.Add("Le nombre Pi est infini et irrationnel, comme une tarte qu'on ne peut jamais finir de manger!");
        myStringList.Add("0 est le seul nombre qui n'a pas d'inverse multiplicatif. Pas d'ami pour jouer à l'inverse!");
        myStringList.Add("En mathématiques, 2+2 peut donner 22, si on les colle!");
        myStringList.Add("Le nombre zéro n'a été inventé qu'au 5ème siècle! Avant, il y avait 'rien' pour dire 'rien'.");
        
        // Thème: Philosophie
        myStringList.Add("Si un arbre tombe et que personne ne l'entend, a-t-il vraiment fait du bruit?");
        myStringList.Add("Un philosophe grec disait que tout change sauf le changement lui-même. Même les carottes!");
        myStringList.Add("Les philosophes aiment poser des questions, même s'ils n'ont jamais de réponses!");
        myStringList.Add("Pour Descartes, 'Je pense, donc je suis.' : ça marche aussi pour le chien qui pense à son os?");
        myStringList.Add("Les philosophes se demandent parfois si la réalité est réelle. Alors, où est le cookie?");

        // Thème: Histoire
        myStringList.Add("En Egypte ancienne, les chats étaient considérés comme des dieux! Imagine si ton chat le savait!");
        myStringList.Add("En Grèce antique, les gens pensaient que le lait venait de la Voie lactée! Etonnant, non?");
        myStringList.Add("Au Moyen Âge, les gens pensaient que prendre un bain était dangereux! Heureusement, ce n'est plus le cas.");
        myStringList.Add("Napoléon mesurait environ 1m69, pas si petit que ça pour son époque!");
        myStringList.Add("Les Vikings pensaient que l'arc-en-ciel était un pont pour les dieux. Alors, pas de trolls sous le pont!");

        // Thème: Cuisine
        myStringList.Add("Les carottes étaient autrefois violettes! Les oranges sont venues plus tard.");
        myStringList.Add("Le miel ne périme jamais. Il pourrait durer des milliers d'années! Parfait pour une ruche éternelle.");
        myStringList.Add("Les pastèques étaient autrefois rondes et pleines de graines, maintenant on les croise sans pépins!");
        myStringList.Add("Les tomates sont des fruits, mais la pizza les a transformées en légumes!");
        myStringList.Add("Les bananes sont légèrement radioactives. Mais pas d'inquiétude, elles ne brillent pas dans le noir!");

        // Thème: Sport
        myStringList.Add("Au rugby, le ballon est ovale pour éviter qu'il roule trop loin.");
        myStringList.Add("Les sumos mangent jusqu'à 10 000 calories par jour! Et toi, combien de cookies?");
        myStringList.Add("Le hockey a été inventé au Canada. La glace, c'est leur terrain de jeu!");
        myStringList.Add("En football, la plupart des gardiens ne marquent jamais de buts!");
        myStringList.Add("La plus longue partie de tennis a duré 11 heures et 5 minutes! Les joueurs ont eu de la résistance!");

        // Thème: Cinéma
        myStringList.Add("Dans les films, la pluie est souvent du lait pour bien la voir à l'écran!");
        myStringList.Add("Les sons des dinosaures dans les films viennent souvent... de tortues! Etonnant, non?");
        myStringList.Add("Les acteurs de films d'horreur mangent parfois du chocolat avant les scènes terrifiantes. Bon pour le moral!");
        myStringList.Add("Un film d'une minute prend parfois des jours à filmer. Et tu pensais que les films étaient rapides!");
        myStringList.Add("Dans les films, les explosions sont souvent petites. La magie du cinéma les rend énormes!");

        // Thème: Informatique
        myStringList.Add("Le premier disque dur pouvait stocker l'équivalent d'une seule photo. Aujourd'hui, on peut stocker des milliers!");
        myStringList.Add("Les ordinateurs ne comprennent que le langage binaire: des 0 et des 1. Imagine leur tête avec des mots!");
        myStringList.Add("Les souris d'ordinateur ont été inventées en 1964 et étaient en bois!");
        myStringList.Add("Le premier virus informatique s'appelait 'Creeper'. Il affichait juste 'I'm the creeper, catch me if you can!' sur les écrans.");
        myStringList.Add("En 1956, le premier disque dur pesait une tonne et avait la taille d'un frigo!");

        // Thème: Sciences
        myStringList.Add("Les poulpes ont trois coeurs. Un pour chaque tentacule? Non, mais c'est pratique!");
        myStringList.Add("La Lune s'éloigne de la Terre de 3,8 cm par an. Pas trop vite, s'il te plaît!");
        myStringList.Add("Les fourmis n'ont pas de poumons! Elles respirent par de petits trous dans leur corps.");
        myStringList.Add("Les grenouilles n'ont pas de cou! Pas besoin de foulard en hiver.");
        myStringList.Add("Le soleil est si grand qu'il pourrait contenir un million de Terres. Incroyable, non?");

        // Thème: Bande dessinée
        myStringList.Add("Superman était d'abord un méchant dans sa toute première version. Heureusement, il a changé de côté!");
        myStringList.Add("Spider-Man est apparu pour la première fois en 1962 dans le magazine Amazing Fantasy.");
        myStringList.Add("Le tout premier personnage de Disney était un lapin nommé Oswald. Mickey est venu plus tard!");
        myStringList.Add("Les Schtroumpfs ont été créés en 1958 par Peyo, un dessinateur belge.");
        myStringList.Add("Batman ne sourit presque jamais dans les bandes dessinées. C'est un super-héros très sérieux!");

        // Thème: Mathématiques
        myStringList.Add("Un cercle a un nombre infini de côtés! Mais il n'est pas pointilleux!");
        myStringList.Add("Les nombres ne se terminent jamais! Même pas le zéro!");
        myStringList.Add("En mathématiques, on dit qu'il y a plus d'infinis que d'autres. Assez pour tout le monde?");
        myStringList.Add("Les chiffres romains n'ont pas de zéro! Ils comptaient sans rien.");
        myStringList.Add("Le nombre Pi commence par 3,14, mais il ne finit jamais. C'est comme une pizza sans fin!");
        
        // Thème: Philosophie
        myStringList.Add("Si personne ne voit un lion dans la savane, est-il en train de danser?");
        myStringList.Add("Si un arbre tombe dans la forêt sans témoin, fait-il vraiment du bruit?");
        myStringList.Add("Les philosophes disent que penser rend réel. Pense à une glace... mais elle n'apparaît pas!");
        myStringList.Add("Pour Socrate, le vrai savoir est de savoir qu'on ne sait rien. Une bonne excuse pour ne pas réviser?");
        myStringList.Add("Descartes disait: 'Je pense, donc je suis.' Mais est-ce que le chat pense qu'il est?");

        // Thème: Histoire
        myStringList.Add("Les Egyptiens anciens croyaient que les chats avaient des super pouvoirs. Les chats sont contents de l'apprendre!");
        myStringList.Add("Les chevaliers du Moyen Âge avaient des armures si lourdes qu'ils ne pouvaient pas se relever seuls!");
        myStringList.Add("Les pharaons d'Egypte se faisaient parfois enterrer avec de la nourriture. Des en-cas pour l'au-delà!");
        myStringList.Add("Au Japon ancien, les ninjas utilisaient parfois des oeufs remplis de poivre pour échapper à leurs ennemis.");
        myStringList.Add("Au Moyen Âge, prendre un bain était rare. Les odeurs aussi étaient médiévales!");

        // Thème: Cuisine
        myStringList.Add("Les carottes étaient violettes avant! Les oranges sont arrivées après, en star du potager.");
        myStringList.Add("Les pommes de terre contiennent de la vitamine C! Un fruit ou un légume?");
        myStringList.Add("En Corée, il existe une soupe d'anniversaire! Manger la soupe rend plus vieux?");
        myStringList.Add("Les nouilles les plus longues jamais faites mesuraient plus de 3 kilomètres!");
        myStringList.Add("La plus grande pizza du monde mesurait 1261 m². De quoi nourrir tout un stade!");

        // Thème: Sport
        myStringList.Add("Le footballeur le plus rapide du monde court à plus de 36 km/h. Presque aussi vite qu'une moto!");
        myStringList.Add("Les sumos pèsent en moyenne 150 kg, c'est comme 25 ballons de bowling!"); 
        myStringList.Add("Le football se joue avec les pieds, mais les gardiens l'arrêtent souvent avec les mains!");
        myStringList.Add("Le basket a été inventé avec des paniers de pêche au lieu de filets!");
        myStringList.Add("Les jeux olympiques n'avaient pas de médailles d'or au départ, seulement de l'argent!");

        // Thème: Cinéma
        myStringList.Add("Les créatures dans les films de dinosaures rugissent comme des tortues! Qui l'aurait cru?");
        myStringList.Add("Dans le premier dessin animé de Mickey, il conduisait un bateau. On l'appelait Steamboat Willie.");
        myStringList.Add("Le son des sabres laser dans Star Wars est fait avec des moteurs de projecteurs et des télévisions!");
        myStringList.Add("Dans les films, les bruits de pas sont souvent faits avec des noix de coco. Oui, même pour les chevaux!");
        myStringList.Add("Les scènes d'hiver sont souvent filmées avec du papier ou du sel pour faire la neige.");

        // Thème: Informatique
        myStringList.Add("Les ordinateurs ne comprennent que les 0 et les 1. Pour eux, c'est noir ou blanc!");
        myStringList.Add("Le premier email de l'histoire disait simplement: QWERTYUIOP.");
        myStringList.Add("Le premier disque dur pesait une tonne et stockait moins qu'une seule photo de ton téléphone!");
        myStringList.Add("Les souris d'ordinateur s'appelaient d'abord des 'trackers'. Pas aussi mignon qu'une souris!");
        myStringList.Add("Le terme 'bug' vient d'un insecte trouvé dans un ordinateur de la Navy en 1947!");

        // Thème: Sciences
        myStringList.Add("Les fourmis peuvent soulever 50 fois leur propre poids! Imagine soulever 50 fois ton sac à dos.");
        myStringList.Add("Les étoiles que tu vois sont peut-être déjà éteintes. Leur lumière a mis des milliers d'années à arriver!");
        myStringList.Add("Les dauphins dorment avec un oeil ouvert pour surveiller les alentours.");
        myStringList.Add("Si on met toutes les fourmis de la planète ensemble, elles pèseraient autant que tous les humains.");
        myStringList.Add("Les oiseaux sont des descendants des dinosaures. Les pigeons de ton quartier? Des mini-rex!");

        // Thème: Bande dessinée
        myStringList.Add("Batman ne sourit jamais! Même pour les photos.");
        myStringList.Add("Le premier super-héros était en fait un méchant. Superman a d'abord commencé comme un anti-héros.");
        myStringList.Add("Le créateur de Spider-Man, Stan Lee, n'a pas inventé de pouvoirs pour Peter Parker... c'est l'araignée qui les a donnés!");
        myStringList.Add("Les Schtroumpfs ont une seule couleur... sauf pour le Grand Schtroumpf, qui porte du rouge!");
        myStringList.Add("Astérix et Obélix sont nés dans un petit village en France mais sont connus dans le monde entier.");

        // Thème: Mathématiques
        myStringList.Add("Le nombre Pi ne finit jamais! Il commence par 3,14 mais continue à l'infini. La plus longue décimale jamais trouvée contient 50 000 milliards de chiffres!");
        myStringList.Add("Les mathématiciens appellent zéro un 'nombre mystérieux'. Essaye de diviser quelque chose par zéro... même les calculatrices sont confuses!");
        myStringList.Add("Un cercle a une infinité de côtés! Chaque côté est infiniment petit.");
        myStringList.Add("En mathématiques, il y a différents types d'infinis! Oui, des infinis plus grands que d'autres!");
        myStringList.Add("Le chiffre '1' est aussi vieux que l'humanité! Il est apparu pour compter les choses... et surtout les moutons!");

        // Thème: Philosophie
        myStringList.Add("Si un arbre tombe sans que personne ne l'entende, a-t-il vraiment fait du bruit?");
        myStringList.Add("Les philosophes se posent des questions comme: 'Pourquoi sommes-nous là?' mais aussi 'Pourquoi les pizzas rondes viennent-elles dans des boîtes carrées?'");
        myStringList.Add("Le philosophe Descartes disait: 'Je pense, donc je suis.' Et ton chat? Il pense donc il est... affamé?");
        myStringList.Add("Les Grecs anciens croyaient que la Terre était au centre de l'univers. Et que le Soleil tournait autour d'elle!");
        myStringList.Add("Les philosophes de l'Inde ancienne ont réfléchi sur l'univers... bien avant que les télescopes n'existent!");

        // Thème: Histoire
        myStringList.Add("En Egypte antique, les chats étaient tellement respectés qu'on les considérait comme des dieux!");
        myStringList.Add("Les chevaliers du Moyen Âge portaient des armures si lourdes qu'ils avaient du mal à se relever après une chute!");
        myStringList.Add("Napoléon était grand pour son époque! Le 'petit caporal' mesurait environ 1,69 mètre.");
        myStringList.Add("Les pharaons d'Egypte ont construit des pyramides sans machines, seulement avec la force humaine et des rampes!");
        myStringList.Add("Au Moyen Âge, les bains étaient rares. On croyait même que l'eau pouvait rendre malade!");

        // Thème: Cuisine
        myStringList.Add("Les bananes sont légèrement radioactives! Mais pas d'inquiétude, elles sont sûres à manger.");
        myStringList.Add("Les carottes étaient violettes à l'origine! Les carottes oranges ont été cultivées aux Pays-Bas.");
        myStringList.Add("La pastèque est en fait un légume! Elle appartient à la même famille que les concombres.");
        myStringList.Add("Les pommes de terre ont été considérées comme des plantes toxiques quand elles sont arrivées en Europe!");
        myStringList.Add("Le chocolat blanc n'est pas vraiment du chocolat! Il est fait avec du beurre de cacao mais sans cacao.");

        // Thème: Sport
        myStringList.Add("Les joueurs de sumo mangent jusqu'à 10 000 calories par jour, soit 20 Big Macs!");
        myStringList.Add("La plus longue partie de tennis a duré plus de 11 heures! Les joueurs étaient épuisés.");
        myStringList.Add("Au football, le gardien de but est le seul joueur autorisé à toucher le ballon avec les mains.");
        myStringList.Add("Les jeux olympiques antiques se jouaient entièrement nus! Pas de tenues d'athlète à l'époque.");
        myStringList.Add("Le hockey est si populaire au Canada que les écoles ferment parfois pour les grandes compétitions.");

        // Thème: Cinéma
        myStringList.Add("Dans Star Wars, les sons des sabres laser viennent de bruits de moteurs et de télévisions.");
        myStringList.Add("Le premier dessin animé de Mickey Mouse, 'Steamboat Willie', est sorti en 1928.");
        myStringList.Add("Le film Jurassic Park utilisait des cris de tortues pour imiter les rugissements des dinosaures!");
        myStringList.Add("Dans les films, la pluie est souvent faite avec du lait pour mieux apparaître à l'écran!");
        myStringList.Add("Dans de nombreux films, les bruits de pas des chevaux sont faits avec des noix de coco.");

        // Thème: Informatique
        myStringList.Add("Les premiers disques durs pesaient une tonne et stockaient moins de données qu'une simple photo!");
        myStringList.Add("Le premier virus informatique a été créé en 1983 et s'appelait 'Elk Cloner'.");
        myStringList.Add("Le langage informatique le plus utilisé, le binaire, est uniquement composé de 0 et de 1.");
        myStringList.Add("Les premières souris d'ordinateur étaient faites de bois! Elles n'avaient pas de molette.");
        myStringList.Add("En 1947, un insecte a été trouvé dans un ordinateur, créant le terme 'bug' en informatique.");

        // Thème: Sciences
        myStringList.Add("Les étoiles que tu vois dans le ciel sont peut-être déjà mortes. Leur lumière a mis des années à nous atteindre!");
        myStringList.Add("Le poulpe a trois coeurs! Un pour chaque tentacule? Non, mais il en a besoin pour survivre.");
        myStringList.Add("Les fourmis n'ont pas de poumons. Elles respirent par de petits trous dans leur corps.");
        myStringList.Add("La Lune s'éloigne de la Terre de 3,8 cm chaque année. Dans le futur, elle sera beaucoup plus loin!");
        myStringList.Add("La Terre tourne si vite qu'à l'équateur, on se déplace à plus de 1600 km/h sans s'en rendre compte!");

        // Thème: Bande dessinée
        myStringList.Add("Superman a d'abord été créé comme un méchant avant de devenir un super-héros!");
        myStringList.Add("Spider-Man est apparu pour la première fois en 1962 dans une bande dessinée appelée 'Amazing Fantasy'.");
        myStringList.Add("Le tout premier personnage de Disney était un lapin nommé Oswald, bien avant Mickey Mouse.");
        myStringList.Add("Batman ne sourit presque jamais dans les bandes dessinées. Il est un super-héros très sérieux!");
        myStringList.Add("Les Schtroumpfs sont des personnages belges créés en 1958 par le dessinateur Peyo.");

            myStringList.Add("Le plus grand piano du monde fait plus de 5 mètres de long et pèse aussi lourd qu'une petite voiture!");
        myStringList.Add("Beethoven était sourd quand il a composé certaines de ses meilleures oeuvres. Il ressentait la musique!");
        myStringList.Add("Les violons sont faits de bois, et le plus vieux violon encore joué date du XVIIe siècle!");
        myStringList.Add("Les battements du tambour d'une fanfare peuvent être entendus à plus d'un kilomètre!");
        myStringList.Add("Une baleine chante à 300 décibels, plus fort qu'un concert de rock! Heureusement, elle le fait sous l'eau.");
        
        // Thème: Animaux
        myStringList.Add("Les pieuvres ont trois coeurs! Un pour chaque tentacule? Non, mais elles en ont besoin pour vivre sous l'eau.");
        myStringList.Add("Les koalas dorment jusqu'à 20 heures par jour! Ils sont les champions de la sieste.");
        myStringList.Add("Les dauphins dorment avec un oeil ouvert pour rester attentifs aux dangers.");
        myStringList.Add("Les escargots peuvent dormir pendant trois ans d'affilée! Pas de réveil nécessaire.");
        myStringList.Add("Les grenouilles absorbent de l'eau par leur peau, elles n'ont donc pas besoin de boire comme nous!");
        
        // Thème: Astrologie
        myStringList.Add("Les anciens Egyptiens croyaient que les étoiles influençaient notre vie. Ils sont parmi les premiers astrologues!");
        myStringList.Add("Selon l'astrologie chinoise, chaque année est associée à un animal, comme le rat, le tigre ou le dragon!");
        myStringList.Add("Les Babyloniens ont inventé les signes du zodiaque il y a plus de 2000 ans.");
        myStringList.Add("En astrologie, chaque planète est censée influencer un aspect de notre personnalité.");
        myStringList.Add("Les signes astrologiques changent tous les 30 jours environ, suivant les mouvements des étoiles.");

        // Thème: Astronomie
        myStringList.Add("Le Soleil est si grand qu'on pourrait y mettre un million de planètes comme la Terre!");
        myStringList.Add("Un jour sur Vénus dure plus longtemps qu'une année sur Vénus. Lente, la rotation de Vénus!");
        myStringList.Add("Les étoiles que tu vois sont peut-être déjà éteintes. Leur lumière a mis des années à arriver jusqu'à nous!");
        myStringList.Add("Les trous noirs sont si puissants que même la lumière ne peut pas s'en échapper!");
        myStringList.Add("La Lune s'éloigne de la Terre d'environ 3,8 cm par an. Dans le futur, elle sera bien plus loin!");
        
        // Thème: Littérature
        myStringList.Add("Le livre le plus vieux connu est 'L'Epopée de Gilgamesh', qui a plus de 4000 ans!");
        myStringList.Add("Le mot le plus long dans la langue française, 'anticonstitutionnellement', a 25 lettres!");
        myStringList.Add("Les aventures de Sherlock Holmes ont popularisé le détective! Mais Sherlock ne disait jamais 'Elémentaire, mon cher Watson.'");
        myStringList.Add("Les contes de Grimm, comme Hansel et Gretel, ont été écrits il y a plus de 200 ans.");
        myStringList.Add("L'écrivain Charles Dickens a inventé de nombreux mots, comme 'boredom' (l'ennui en anglais)!");
        
        // Thème: Musique
        myStringList.Add("Les violons peuvent être faits de plus de 70 morceaux de bois différents!");
        myStringList.Add("Mozart a écrit sa première symphonie à 8 ans! Que faisais-tu à cet âge?");
        myStringList.Add("Les tambours en Afrique sont utilisés pour parler entre villages! Des messages rythmés qui voyagent loin.");
        myStringList.Add("Le plus grand orgue du monde a plus de 33 000 tuyaux et peut être entendu à des kilomètres!");
        myStringList.Add("Les chanteurs d'opéra peuvent briser du verre avec leur voix en chantant très fort!");

        // Thème: Animaux
        myStringList.Add("Les coeurs des pieuvres battent trois fois plus vite quand elles nagent!");
        myStringList.Add("Les éléphants sont les seuls animaux qui ne peuvent pas sauter. Imagine un éléphant bondissant!");
        myStringList.Add("Les dauphins ont des prénoms! Ils utilisent des sifflements uniques pour s'appeler entre eux.");
        myStringList.Add("Un kangourou ne peut pas marcher à reculons! Il doit toujours aller de l'avant.");
        myStringList.Add("Les girafes dorment moins de 30 minutes par jour. Pas de grasses matinées pour elles!");

        // Thème: Astrologie
        myStringList.Add("Le zodiaque chinois a 12 animaux et chaque année, on change! Es-tu un dragon, un rat ou un tigre?");
        myStringList.Add("Les astrologues de l'Inde ancienne croyaient que chaque étoile influençait notre destin!");
        myStringList.Add("Les signes astrologiques sont basés sur la position des étoiles il y a plus de 2000 ans.");
        myStringList.Add("Les anciens Romains croyaient que chaque planète était un dieu! Mars, par exemple, était le dieu de la guerre.");
        myStringList.Add("Les Egyptiens utilisaient des étoiles pour prédire les inondations du Nil. Astrologie et météo!");

        // Thème: Astronomie
        myStringList.Add("Les étoiles que tu vois sont peut-être éteintes! Leur lumière met des années à nous parvenir.");
        myStringList.Add("Un jour sur Jupiter ne dure que 10 heures. Rapide, la planète géante!");
        myStringList.Add("Les astronautes grandissent de quelques centimètres dans l'espace, car ils sont en apesanteur!");
        myStringList.Add("Il y a une tempête sur Jupiter qui dure depuis plus de 300 ans!");
        myStringList.Add("Le Soleil est une étoile! Mais heureusement, il est bien plus proche de nous que les autres.");

        // Thème: Littérature
        myStringList.Add("Le premier roman détective est 'Les meurtres de la rue Morgue' d'Edgar Allan Poe.");
        myStringList.Add("Les contes de fées originaux des frères Grimm étaient bien plus sombres et effrayants!");
        myStringList.Add("Jules Verne a imaginé des voyages dans l'espace bien avant que les fusées n'existent!");
        myStringList.Add("Le livre le plus vendu au monde, après la Bible, est Don Quichotte!");
        myStringList.Add("L'écrivain Victor Hugo pouvait écrire en dormant! On dit qu'il rêvait de ses romans.");
        myStringList.Add("Les tambours sont l'un des plus vieux instruments du monde, ils existaient il y a 6 000 ans!");
        myStringList.Add("Mozart a composé sa première musique à 5 ans! Certains enfants apprennent tout juste à écrire à cet âge.");
        myStringList.Add("Les sons aigus de la flûte traversent facilement les murs – parfait pour embêter les voisins!");
        myStringList.Add("Beethoven continuait de composer même en étant sourd, en sentant les vibrations sur son piano.");
        myStringList.Add("Les notes de musique Do, Ré, Mi, Fa, Sol, La, Si viennent du chant d'une prière en latin!");

        // Thème: Animaux
        myStringList.Add("Les hippocampes mâles portent les bébés! Ce sont les seuls papas dans le monde animal à faire ça.");
        myStringList.Add("Les grenouilles boivent par leur peau, elles n'ont pas besoin de boire avec leur bouche!");
        myStringList.Add("Les pieuvres ont trois coeurs, parfait pour une vie palpitante sous l'océan!");
        myStringList.Add("Les chiens sont capables de comprendre environ 100 mots, presque comme un enfant de 2 ans.");
        myStringList.Add("Les escargots peuvent dormir pendant trois ans d'affilée. Imagine une sieste de plusieurs années!");

        // Thème: Astrologie
        myStringList.Add("Les signes astrologiques changent tous les mois, basés sur les constellations visibles dans le ciel.");
        myStringList.Add("Dans l'astrologie chinoise, chaque année correspond à un animal, comme le dragon ou le rat.");
        myStringList.Add("Les Babyloniens sont les premiers à avoir divisé le ciel en 12 signes astrologiques il y a 2000 ans.");
        myStringList.Add("Les astrologues croient que la position des étoiles influence notre personnalité!");
        myStringList.Add("En astrologie, chaque planète symbolise une émotion: Mars est la planète de l'énergie, et Vénus celle de l'amour.");

        // Thème: Astronomie
        myStringList.Add("Le Soleil est tellement grand qu'on pourrait y faire entrer un million de Terres!");
        myStringList.Add("Les trous noirs sont des zones de l'espace où la gravité est si forte que rien ne peut s'en échapper!");
        myStringList.Add("Un jour sur la planète Vénus dure plus longtemps qu'une année! Elle tourne très lentement.");
        myStringList.Add("Les étoiles que l'on voit la nuit sont peut-être déjà éteintes, leur lumière met des années à nous parvenir.");
        myStringList.Add("La Lune s'éloigne de la Terre d'environ 3,8 cm chaque année. Dans le futur, elle sera bien plus loin de nous!");

        // Thème: Littérature
        myStringList.Add("Le premier conte de fées écrit remonte au 2e siècle: ça fait près de 2000 ans de magie!");
        myStringList.Add("Les aventures de Sherlock Holmes sont si populaires que des fans écrivent encore aujourd'hui de nouvelles histoires sur lui.");
        myStringList.Add("J.K. Rowling a eu l'idée de Harry Potter dans un train et a écrit le premier livre dans un café.");
        myStringList.Add("Le mot 'livre' vient du latin 'liber', qui signifie 'écorce' car les anciens écrivaient sur de l'écorce d'arbre.");
        myStringList.Add("L'auteur Jules Verne a imaginé des sous-marins, des fusées et des voyages dans l'espace bien avant que ça n'existe!");
            // Thème: Requins
        myStringList.Add("Les requins perdent des milliers de dents dans leur vie, mais elles repoussent comme les poils chez nous!");
        myStringList.Add("Le requin-baleine est si grand qu'un enfant pourrait nager dans sa bouche... mais il préfère le plancton!");
        myStringList.Add("Les requins sont là depuis plus de 400 millions d'années, bien avant les dinosaures!");
        myStringList.Add("Les requins peuvent sentir une goutte de sang dans une piscine olympique entière!");
        myStringList.Add("Certains requins brillent dans le noir! Ils utilisent la bioluminescence pour se cacher des prédateurs.");
        
        // Thème: Araignées
        myStringList.Add("Les araignées peuvent fabriquer plusieurs types de soie pour leurs toiles, chacune avec une fonction spéciale!");
        myStringList.Add("Les araignées sauteuses ont une super vision et peuvent sauter 50 fois la longueur de leur corps!");
        myStringList.Add("Certains types d'araignées, comme la tarentule, peuvent vivre jusqu'à 30 ans. Pas si éphémères!");
        myStringList.Add("Les araignées ne peuvent pas vraiment 'mordre' car elles n'ont pas de dents comme nous!");
        myStringList.Add("Les araignées utilisent la soie de leurs toiles pour créer des parachutes et s'envoler au vent!");
        
        // Thème: Serpents
        myStringList.Add("Les serpents n'ont pas de paupières, ils dorment les yeux grands ouverts. Effrayant, non?");
        myStringList.Add("Les cobras royaux peuvent siffler aussi fort qu'un chat qui grogne pour faire fuir les ennemis.");
        myStringList.Add("Les pythons peuvent jeûner pendant un an après un gros repas, mais ils digèrent lentement!");
        myStringList.Add("Le serpent le plus rapide du monde, le mamba noir, peut atteindre 20 km/h. Pas besoin de vélo!");
        myStringList.Add("Les serpents 'sentent' avec leur langue, en captant des odeurs dans l'air pour trouver leur nourriture.");

        // Thème: Géométrie
        myStringList.Add("Un cercle a une infinité de côtés! Eh oui, c'est comme un polygone avec des côtés infiniment petits.");
        myStringList.Add("Un triangle est la seule forme qui ne peut pas s'effondrer sous pression, c'est pour ça qu'on l'utilise dans les ponts!");
        myStringList.Add("Les abeilles utilisent la géométrie parfaite des hexagones pour construire leurs ruches. Pas besoin de règle!");
        myStringList.Add("Les angles d'un triangle font toujours 180 degrés, peu importe sa taille ou sa forme!");
        myStringList.Add("Un carré magique est une grille où la somme des nombres de chaque ligne, colonne et diagonale est la même. Magique, non?");
        
        // Thème: Physique
        myStringList.Add("La gravité sur la Lune est six fois plus faible que sur Terre. Sur la Lune, tu pèserais comme une plume!");
        myStringList.Add("Si tu pouvais atteindre la vitesse de la lumière, tu pourrais faire le tour de la Terre sept fois en une seconde!");
        myStringList.Add("Les atomes sont si petits qu'il y a environ un milliard d'atomes dans une goutte d'eau.");
        myStringList.Add("Le son se déplace plus de quatre fois plus vite dans l'eau que dans l'air!");
        myStringList.Add("La lumière prend 8 minutes pour voyager du Soleil jusqu'à la Terre. Quand tu regardes le Soleil, tu vois le passé!");

        // Thème: Physique Quantique
        myStringList.Add("En physique quantique, une particule peut être dans deux endroits en même temps, ça s'appelle la superposition.");
        myStringList.Add("Les particules quantiques peuvent s'entrelacer et communiquer instantanément, même si elles sont à des années-lumière l'une de l'autre!");
        myStringList.Add("Les électrons dans un atome ne 'tournent' pas vraiment autour du noyau: ils sont dans des nuages flous appelés orbitales.");
        myStringList.Add("Dans le monde quantique, observer une particule change son comportement. C'est comme si elle nous voyait la regarder!");
        myStringList.Add("Les chats de Schrödinger, dans la théorie, peuvent être vivants et morts en même temps jusqu'à ce qu'on les observe!");

        myStringList.Add("Le chien a un odorat 40 fois plus puissant que celui des humains! Il peut même détecter des maladies.");
        myStringList.Add("Les chiots naissent sourds et aveugles. Ils commencent à entendre et voir après 2 semaines!");
        myStringList.Add("Le chien le plus rapide au monde, le Greyhound, peut courir à plus de 70 km/h!");

        // Thème : Loups
        myStringList.Add("Les loups peuvent parcourir jusqu'à 200 km en une seule journée à la recherche de nourriture!");
        myStringList.Add("Un loup peut entendre des sons jusqu'à 16 km de distance par temps calme!");
        myStringList.Add("Les loups hurlent pour communiquer avec leur meute et se retrouver dans la forêt.");

        // Thème : Animaux
        myStringList.Add("Les pieuvres ont trois coeurs! Deux pour leurs branchies et un pour le reste du corps.");
        myStringList.Add("Les éléphants sont les seuls animaux qui ne peuvent pas sauter, même avec leurs puissantes pattes!");
        myStringList.Add("Les manchots mâles couvent les oeufs pendant que les femelles vont chercher de la nourriture.");

        // Thème : Géographie
        myStringList.Add("La montagne la plus haute du monde est l'Everest, mesurant environ 8 848 mètres de hauteur.");
        myStringList.Add("La ville de Norilsk, en Russie, est l'une des plus froides, avec des températures atteignant -50°C!");
        myStringList.Add("Le Sahara est si grand qu'il pourrait contenir les Etats-Unis presque au complet!");

        // Thème : Tremblements de terre
        myStringList.Add("Chaque année, il y a environ 500 000 tremblements de terre, mais seulement 100 000 sont ressentis par les humains.");
        myStringList.Add("Les tremblements de terre se produisent lorsque les plaques tectoniques bougent sous la croûte terrestre.");
        myStringList.Add("Le séisme le plus puissant jamais enregistré a eu lieu au Chili en 1960, avec une magnitude de 9,5!");

        // Thème : Jeux vidéo
        myStringList.Add("Le premier jeu vidéo de l'histoire, 'Pong', a été créé en 1972 et était un simple jeu de tennis.");
        myStringList.Add("Mario, le célèbre plombier de Nintendo, devait à l'origine être un charpentier!");
        myStringList.Add("Dans le monde de Minecraft, chaque bloc mesure environ un mètre de côté, comme un cube géant!");

        // Thème : Histoire
        myStringList.Add("Les pyramides égyptiennes ont plus de 4 500 ans! Elles ont survécu à de nombreux rois et royaumes.");
        myStringList.Add("Le cheval de Troie est une ruse légendaire utilisée pour envahir la ville de Troie.");
        myStringList.Add("Jules César a inventé le calendrier julien, l'ancêtre de notre calendrier actuel!");

        // Thème : Guitares
        myStringList.Add("La guitare électrique a été inventée dans les années 1930, changeant le monde de la musique pour toujours.");
        myStringList.Add("La plus grande guitare du monde mesure plus de 13 mètres de long!");
        myStringList.Add("Une guitare classique a six cordes, mais certaines peuvent en avoir jusqu'à douze!");

        // Thème : Electricité
        myStringList.Add("Les anguilles électriques peuvent produire des décharges de plus de 600 volts pour se défendre!");
        myStringList.Add("L'électricité voyage presque à la vitesse de la lumière, soit environ 300 000 km par seconde.");
        myStringList.Add("La foudre est une décharge électrique naturelle pouvant atteindre 1 milliard de volts!");

        // Thème : Amour
        myStringList.Add("Le coeur humain bat environ 100 000 fois par jour, et souvent plus quand on est amoureux!");
        myStringList.Add("Les flamants roses se tiennent souvent en couple toute leur vie, partageant un lien spécial.");
        myStringList.Add("Les pingouins offrent souvent des cailloux à leurs partenaires en signe d'amour et de dévotion.");

        // Thème : Guinness World Records
        myStringList.Add("Le plus grand hamburger jamais cuisiné pesait 1 164 kg! Il a été servi à une fête aux Etats-Unis.");
        myStringList.Add("La plus longue pizza au monde mesurait 1 930 mètres! Elle a été préparée en Californie.");
        myStringList.Add("La personne la plus grande de l'histoire mesurait 2,72 mètres. Robert Wadlow a grandi jusqu'à 22 ans!");
        myStringList.Add("Le chien avec les plus longues oreilles s'appelle Lou, et ses oreilles mesurent 34 cm chacune!");
        myStringList.Add("La plus grande collection de chaussures de sport compte plus de 2 500 paires! Elle appartient à un passionné américain.");
        myStringList.Add("Le plus gros feu d'artifice jamais lancé pesait 2 797 kg et a été tiré dans le ciel du Colorado.");
        myStringList.Add("La plus longue bicyclette jamais construite faisait 35,79 mètres de long. Imaginez pour la tourner!");
        myStringList.Add("Le chat le plus vieux jamais connu, nommé Crème Puff, a vécu jusqu'à 38 ans!");
        myStringList.Add("La plus grande boule de caoutchouc fait plus de 4 000 kg et se trouve en Floride.");
        myStringList.Add("La plus grosse citrouille du monde pèse 1 226 kg et a été cultivée par un fermier belge.");
        myStringList.Add("Le plus grand nombre de hot-dogs mangés en 10 minutes est de 76, un record établi par Joey Chestnut.");
        myStringList.Add("Le plus grand nombre de dominos tombés en une fois est de plus de 4,8 millions, réalisés par une équipe en Allemagne.");
        myStringList.Add("Le chien le plus rapide du monde, un lévrier Greyhound, a atteint une vitesse de 72 km/h!");
        myStringList.Add("Le plus grand livre du monde mesure 5 mètres de haut et pèse 1500 kg. Il se trouve à Dubaï.");
        myStringList.Add("Le plus grand nombre de ballons éclatés par un chien en une minute est de 100! Un record tenu par Twinkie.");
        myStringList.Add("Le plus grand nombre de roues arrières à moto faites en une minute est de 70. Quel équilibre incroyable!");
        myStringList.Add("La personne ayant collectionné le plus de peluches possède plus de 20 000 ours en peluche!");
        myStringList.Add("Le plus gros oeuf jamais pondu par une poule pesait 454 grammes, soit presque un demi-kilo!");
        myStringList.Add("Le plus grand château de sable construit mesurait 17,66 mètres de haut et a été créé au Danemark.");
        myStringList.Add("Le plus long saut en parachute de l'histoire a été de plus de 38 kilomètres de hauteur!");
        myStringList.Add("Le plus petit avion habité ne mesure que 2,68 mètres de long. Un véritable mini-avion!");
        myStringList.Add("La plus grande collection de jouets Kinder contient plus de 12 000 petites figurines.");
        myStringList.Add("Le plus jeune docteur de l'histoire a obtenu son doctorat à seulement 13 ans!");
        myStringList.Add("Le plus grand nombre de bouteilles de lait transportées sur la tête est de 11, un record impressionnant!");
        myStringList.Add("La personne qui a battu le plus grand nombre de records Guinness en détient plus de 600 à son nom.");
        myStringList.Add("Le plus long temps passé sans dormir est de 11 jours! Un record établi par un jeune homme en 1964.");
        myStringList.Add("La plus grande distance parcourue sur une corde raide est de 1,9 km. Un exploit qui défie le vertige!");
        myStringList.Add("Le plus grand nombre de langues parlées par une seule personne est de 58!");
        myStringList.Add("La plus longue barbe mesurait plus de 5 mètres de long et appartenait à un homme indien.");
        myStringList.Add("Le plus grand nombre de sauts à la corde en 24 heures est de plus de 151 000!");
        // Thème : Médecine
        myStringList.Add("Le plus petit os du corps humain est dans l'oreille et mesure environ 3 millimètres. On l'appelle l'étrier!");
        myStringList.Add("Le coeur humain bat environ 100 000 fois par jour, soit environ 35 millions de battements chaque année.");
        myStringList.Add("Les os sont quatre fois plus solides que le béton! Ils supportent le poids du corps et se réparent eux-mêmes.");
        myStringList.Add("Les ongles poussent plus vite sur la main que l'on utilise le plus. C'est pourquoi les droitiers ont l'ongle droit plus long!");
        myStringList.Add("Les bébés naissent avec environ 270 os, mais en grandissant, beaucoup fusionnent pour en former 206.");
        myStringList.Add("Les globules rouges transportent l'oxygène dans le corps et vivent environ 120 jours avant d'être remplacés.");
        myStringList.Add("Chaque poumon contient environ 300 millions de petits sacs d'air appelés alvéoles, pour absorber l'oxygène.");
        myStringList.Add("Le foie est le seul organe humain qui peut repousser et se régénérer après une lésion partielle!");
        myStringList.Add("Les humains produisent en moyenne un litre et demi de salive chaque jour, ce qui remplit deux grandes bouteilles!");
        myStringList.Add("Les muscles des yeux bougent environ 100 000 fois par jour pour ajuster la vue. C'est un vrai exercice!");
        myStringList.Add("La peau est l'organe le plus grand du corps humain et peut représenter jusqu'à 16 % du poids total!");
        myStringList.Add("Les cellules gustatives sur la langue ne vivent que 10 à 14 jours avant d'être remplacées par de nouvelles.");
        myStringList.Add("Les enfants rient environ 300 fois par jour, tandis que les adultes rient seulement 15 à 100 fois.");
        myStringList.Add("Le plus gros organe interne du corps est le foie, qui pèse environ 1,5 kilogramme chez un adulte.");
        myStringList.Add("La moelle osseuse produit environ 2 millions de globules rouges chaque seconde pour renouveler notre sang!");
        myStringList.Add("Environ 70 % du corps humain est constitué d'eau, essentielle pour les organes, les cellules et les processus vitaux.");
        myStringList.Add("Chaque cheveu humain peut supporter environ 100 grammes. Avec tous nos cheveux, on pourrait soulever deux éléphants!");
        myStringList.Add("Les bactéries de notre intestin pèsent environ 1 à 2 kg. Elles aident à digérer les aliments et nous protègent.");
        myStringList.Add("Les os contiennent du calcium, le même minéral présent dans le lait, qui les rend forts et solides.");
        myStringList.Add("Le cerveau humain utilise environ 20 % de l'énergie totale du corps pour fonctionner, même lorsque nous dormons.");
        myStringList.Add("Les ongles et les cheveux continuent de pousser après la mort, car les cellules survivent un peu plus longtemps.");
        myStringList.Add("Les scientifiques estiment que le corps humain est composé de 37 trillions de cellules, chacune remplissant un rôle important.");
        myStringList.Add("Le sens de l'odorat est plus développé chez les femmes que chez les hommes, surtout durant les premières années de vie.");
        myStringList.Add("Le coeur d'un foetus commence à battre environ trois semaines après la conception, un petit miracle de la vie!");
        myStringList.Add("Le corps produit naturellement un anesthésiant appelé endorphine, qui réduit la douleur et améliore notre humeur.");
        myStringList.Add("Le plus long nerf du corps est le nerf sciatique, qui va de la colonne vertébrale jusqu'aux pieds!");
        myStringList.Add("Les os sont composés d'environ 31 % d'eau, ce qui les rend flexibles et résistants.");
        myStringList.Add("Le corps possède environ 650 muscles différents pour bouger, sourire, courir et bien plus encore!");
        myStringList.Add("Les doigts se plient grâce aux tendons et aux muscles qui sont en fait situés dans l'avant-bras.");
        myStringList.Add("La sueur est inodore! Ce sont les bactéries sur la peau qui causent l'odeur quand elles se nourrissent de la sueur.");

        // Thème : Histoire
        myStringList.Add("Les pyramides d'Egypte ont plus de 4 500 ans et ont été construites sans les machines modernes!");
        myStringList.Add("Jules César a été enlevé par des pirates! Quand il a été libéré, il est revenu les capturer.");
        myStringList.Add("La Grande Muraille de Chine mesure plus de 21 000 km de long. Elle est visible de l'espace!");
        myStringList.Add("La Joconde a été volée du Louvre en 1911, mais elle a été retrouvée deux ans plus tard en Italie.");
        myStringList.Add("Les Romains avaient des aqueducs pour amener l'eau dans les villes. Certains fonctionnent encore aujourd'hui!");
        myStringList.Add("Le premier avion piloté par les frères Wright a volé en 1903, parcourant seulement 37 mètres.");
        myStringList.Add("L'Empire mongol de Gengis Khan était si grand qu'il couvrait presque toute l'Asie au 13e siècle.");
        myStringList.Add("Les Vikings n'avaient pas de casques à cornes, contrairement aux images populaires. C'est un mythe!");
        myStringList.Add("Cléopâtre était la dernière reine d'Egypte. Elle parlait plusieurs langues, dont l'égyptien et le grec.");
        myStringList.Add("La première bombe atomique a explosé en 1945 dans le désert du Nouveau-Mexique, changeant le monde pour toujours.");
        myStringList.Add("Les Mayas avaient un calendrier très précis et pensaient que le monde finirait en 2012, ce qui n'est pas arrivé!");
        myStringList.Add("En 1969, Neil Armstrong est devenu le premier homme à marcher sur la Lune avec les mots : « C'est un petit pas pour l'homme... »");
        myStringList.Add("En 1666, un grand incendie a détruit une grande partie de Londres, mais seulement six personnes ont perdu la vie.");
        myStringList.Add("Le Titanic, un énorme paquebot de luxe, a coulé lors de son premier voyage en 1912 après avoir heurté un iceberg.");
        myStringList.Add("L'impressionnisme, un mouvement artistique révolutionnaire, a débuté en France dans les années 1870 avec des peintres comme Monet.");
        myStringList.Add("La ville de Pompéi a été ensevelie sous les cendres d'un volcan en éruption en 79 après J.-C.");
        myStringList.Add("Napoléon Bonaparte mesurait environ 1,69 mètre, une taille normale pour l'époque, contrairement à la légende qui le décrit comme petit.");
        myStringList.Add("L'astronome Galilée a été emprisonné pour avoir affirmé que la Terre tourne autour du Soleil, ce qui était interdit à l'époque.");
        myStringList.Add("Les Jeux olympiques de l'Antiquité, célébrés en Grèce, n'autorisaient que les hommes à participer, et les athlètes concouraient nus!");
        myStringList.Add("Les samouraïs, guerriers du Japon ancien, portaient deux épées et suivaient un code d'honneur strict appelé le bushido.");
        myStringList.Add("La première carte de crédit a été introduite en 1950 par Diners Club, permettant aux gens de payer sans argent liquide.");
        myStringList.Add("L'homme de Néandertal, une espèce humaine disparue, a vécu en Europe il y a des milliers d'années, bien avant l'homme moderne.");
        myStringList.Add("Le premier téléphone a été inventé par Alexander Graham Bell en 1876, permettant aux gens de parler à distance.");
        myStringList.Add("La Guerre de Troie, légendaire guerre entre les Grecs et la ville de Troie, aurait été causée par l'enlèvement d'Hélène.");
        myStringList.Add("La plus ancienne écriture connue date d'environ 5 000 ans. Elle a été inventée par les Sumériens en Mésopotamie.");
        myStringList.Add("Le Mont Saint-Michel en France devient une île à marée haute et est accessible à pied à marée basse.");
        myStringList.Add("Albert Einstein, l'un des plus grands scientifiques de l'histoire, a développé la théorie de la relativité à 26 ans.");
        myStringList.Add("Les chevaliers médiévaux portaient des armures en métal qui pesaient jusqu'à 30 kg, soit le poids d'un gros chien!");
        myStringList.Add("L'Empire romain s'étendait sur trois continents : l'Europe, l'Asie et l'Afrique, à son apogée au 2e siècle.");
        myStringList.Add("La première bibliothèque publique a été fondée en 1731 aux Etats-Unis par Benjamin Franklin.");
        // Thème : Animaux
        myStringList.Add("Les dauphins dorment avec un oeil ouvert pour rester vigilants et éviter les prédateurs!");
        myStringList.Add("Les girafes n'ont que sept vertèbres cervicales, tout comme les humains, malgré leur long cou.");
        myStringList.Add("Les abeilles peuvent reconnaître les visages humains. Elles se souviennent de certains traits, un peu comme nous!");
        myStringList.Add("Le coeur d'une crevette est dans sa tête! Chez certaines espèces, le cerveau est aussi là.");
        myStringList.Add("Le caméléon peut déplacer chaque oeil indépendamment, lui permettant de regarder dans deux directions en même temps.");
        myStringList.Add("Les éléphants ne peuvent pas sauter, mais ils sont d'excellents nageurs et aiment jouer dans l'eau.");
        myStringList.Add("Le cri d'une baleine bleue est si fort qu'il peut être entendu à plus de 800 kilomètres!");
        myStringList.Add("Les pieuvres ont trois coeurs! Deux pompent le sang vers les branchies, et le troisième vers le reste du corps.");
        myStringList.Add("Les pingouins mâles offrent souvent un caillou à la femelle comme cadeau de demande en mariage.");
        myStringList.Add("Les chats domestiques peuvent courir jusqu'à 48 km/h, presque aussi vite qu'un guépard en pleine course.");
        myStringList.Add("Les corbeaux sont incroyablement intelligents et peuvent utiliser des outils, résoudre des problèmes, et même reconnaître les visages humains.");
        myStringList.Add("La langue d'un caméléon est plus longue que son corps. Elle peut attraper des proies en une fraction de seconde!");
        myStringList.Add("Les koalas dorment jusqu'à 20 heures par jour pour économiser l'énergie, car les feuilles d'eucalyptus sont faibles en nutriments.");
        myStringList.Add("Les fourmis n'ont pas de poumons. Elles respirent à travers des petits trous dans leur corps, appelés spiracles.");
        myStringList.Add("Les flamants roses deviennent roses en mangeant des crevettes et des algues, qui contiennent un pigment rose.");
        myStringList.Add("Le colibri est le seul oiseau capable de voler en arrière. Il bat des ailes jusqu'à 80 fois par seconde!");
        myStringList.Add("Les crocodiles avalent des pierres pour les aider à digérer et pour rester équilibrés dans l'eau.");
        myStringList.Add("Les escargots peuvent dormir jusqu'à trois ans d'affilée si les conditions de vie ne sont pas favorables.");
        myStringList.Add("Le poisson-clown, comme dans *Le Monde de Nemo*, change de sexe pour devenir femelle si la dominante disparaît.");
        myStringList.Add("Les ours polaires ont une peau noire sous leur fourrure blanche pour mieux absorber la chaleur du soleil.");
        myStringList.Add("Les chiens possèdent environ 300 millions de récepteurs olfactifs, leur permettant de sentir des odeurs 40 fois mieux que les humains.");
        myStringList.Add("Les papillons goûtent avec leurs pattes, ce qui leur permet de sentir les plantes dès qu'ils se posent dessus.");
        myStringList.Add("Les hippocampes sont les seuls animaux dont le mâle porte et accouche des petits!");
        myStringList.Add("Le grizzly peut courir aussi vite qu'un cheval, atteignant des vitesses de 56 km/h, malgré sa taille imposante.");
        myStringList.Add("Les étoiles de mer n'ont pas de cerveau. Elles utilisent un réseau de nerfs pour se déplacer et réagir.");
        myStringList.Add("Le guépard est l'animal terrestre le plus rapide, capable de courir jusqu'à 112 km/h en courtes pointes.");
        myStringList.Add("Les chauves-souris sont les seuls mammifères capables de voler activement et non seulement de planer.");
        myStringList.Add("Les huîtres peuvent changer de sexe plusieurs fois au cours de leur vie, selon les conditions environnementales.");
        myStringList.Add("Les pandas passent environ 12 heures par jour à manger pour consommer suffisamment de bambou pour survivre.");
        myStringList.Add("Les hippocampes restent fidèles à leur partenaire pour la vie, et les couples nagent en se tenant par la queue.");
        // Thème : Mathématiques
        myStringList.Add("Le nombre Pi ne finit jamais et ne se répète jamais. Les premières décimales sont 3,14159...");
        myStringList.Add("Le zéro a été inventé par les mathématiciens indiens autour du 5e siècle. Avant, on n'avait pas de nombre pour rien!");
        myStringList.Add("Il existe une infinité de nombres premiers, comme 2, 3, 5, 7, et on en découvre encore!");
        myStringList.Add("Le symbole infini a été inventé en 1655 par le mathématicien John Wallis.");
        myStringList.Add("Le nombre 1 n'est pas un nombre premier, car il a seulement un diviseur : lui-même.");
        myStringList.Add("Dans un cube Rubik, il existe plus de 43 quintillions de combinaisons possibles, mais une seule solution!");
        myStringList.Add("Le célèbre théorème de Pythagore existe depuis plus de 2 500 ans et concerne les triangles rectangles.");
        myStringList.Add("Le chiffre 4 est considéré comme malchanceux en Chine parce qu'il se prononce presque comme le mot 'mort'.");
        myStringList.Add("Le nombre 1729 est appelé le « nombre de Hardy-Ramanujan » parce qu'il peut s'écrire comme la somme de deux cubes de deux façons différentes!");
        myStringList.Add("Un cercle a un nombre infini de côtés microscopiques ; c'est ce qui en fait une forme si lisse!");
        myStringList.Add("Le nombre d'or (environ 1,618) est considéré comme une proportion parfaite et se retrouve dans la nature, comme dans les spirales de coquillages.");
        myStringList.Add("Il y a un milliard de secondes dans environ 31,7 ans. Combien de secondes avez-vous déjà vécues?");
        myStringList.Add("Le plus grand nombre nommé est le 'googolplex', un 1 suivi d'un googol de zéros (un googol est un 1 suivi de 100 zéros).");
        myStringList.Add("Les premiers mathématiciens grecs comme Euclide ont développé la géométrie, que l'on utilise encore aujourd'hui!");
        myStringList.Add("La table de multiplication a été inventée en Mésopotamie il y a environ 4 000 ans pour simplifier le commerce.");
        myStringList.Add("Le nombre 13 est considéré comme chanceux dans certaines cultures, mais malchanceux dans d'autres, au point que certains bâtiments sautent l'étage 13!");
        myStringList.Add("Le triangle de Pascal contient des modèles intéressants, comme les puissances de 2 ou les nombres qui apparaissent plusieurs fois.");
        myStringList.Add("Les fractales sont des formes mathématiques qui se répètent à l'infini. Elles ressemblent souvent à des dessins naturels, comme les montagnes et les flocons de neige.");
        myStringList.Add("Un palindrome est un nombre ou un mot qui se lit de la même façon dans les deux sens, comme 121 ou 'kayak'.");
        myStringList.Add("La probabilité d'avoir un jour 29 février est de 1 sur 1461, car c'est un jour supplémentaire tous les quatre ans!");
        myStringList.Add("Les spirales des coquillages et des galaxies suivent souvent une séquence mathématique appelée suite de Fibonacci.");
        myStringList.Add("Le théorème de Fermat a mis plus de 300 ans à être démontré après qu'il a été proposé au 17e siècle!");
        myStringList.Add("L'algèbre tire son nom d'un livre écrit par un mathématicien arabe nommé Al-Khwarizmi au 9e siècle.");
        myStringList.Add("Il existe une 'constantité d'Euler', un nombre spécial nommé e, qui vaut environ 2,718 et qui apparaît dans beaucoup d'équations mathématiques.");
        myStringList.Add("Un polyèdre est une figure en 3D avec des faces plates, comme les cubes et les pyramides.");
        myStringList.Add("Un graphe est un outil mathématique qui permet de représenter des relations. Il est souvent utilisé en informatique et dans les réseaux sociaux!");
        myStringList.Add("Les 'nombres amicaux' sont des paires de nombres, comme 220 et 284, qui partagent une relation mathématique unique.");
        myStringList.Add("La formule de l'aire d'un cercle est basée sur le nombre Pi et le rayon. C'est pourquoi elle est toujours ronde!");
        myStringList.Add("Les nombres imaginaires sont utilisés en mathématiques pour des calculs que les nombres réels ne peuvent pas résoudre.");
        myStringList.Add("Les mathématiciens utilisent les lettres grecques pour représenter des angles et des constantes.");
        // Thème : Mécanique du point
        myStringList.Add("La mécanique du point étudie les mouvements des objets considérés comme des points, sans tenir compte de leur taille ou de leur forme.");
        myStringList.Add("Lorsqu'un objet se déplace, il suit une trajectoire qui peut être droite ou courbée, selon les forces qui agissent sur lui.");
        myStringList.Add("La vitesse d'un objet est la distance parcourue par unité de temps. C'est un concept fondamental en mécanique du point!");
        myStringList.Add("La masse d'un objet détermine sa résistance à l'accélération. Plus l'objet est massif, plus il est difficile à accélérer.");
        myStringList.Add("La force exercée sur un objet est responsable de son accélération. C'est ce que décrit la deuxième loi de Newton.");
        myStringList.Add("Le principe d'inertie stipule qu'un objet au repos restera au repos, et un objet en mouvement continuera à se déplacer, sauf si une force l'arrête.");
        myStringList.Add("La loi de la gravitation de Newton nous dit que tous les objets s'attirent mutuellement avec une force qui dépend de leurs masses et de la distance entre eux.");
        myStringList.Add("La mécanique du point peut être appliquée pour analyser des objets aussi grands qu'une planète ou aussi petits qu'une bille.");
        myStringList.Add("Le travail effectué par une force sur un objet est égal à la force multipliée par la distance parcourue dans la direction de la force.");
        myStringList.Add("L'énergie cinétique est l'énergie qu'un objet possède en raison de son mouvement. Elle est calculée à partir de sa masse et de sa vitesse.");
        myStringList.Add("Lorsqu'un objet est en chute libre, il accélère en raison de la gravité, mais cette accélération reste constante en l'absence de résistance de l'air.");
        myStringList.Add("Le principe de la conservation de la quantité de mouvement stipule que la quantité de mouvement totale d'un système fermé reste constante.");
        myStringList.Add("Un objet en mouvement peut changer de direction en réponse à une force. Cela permet de comprendre les trajectoires courbes, comme celles des planètes.");
        myStringList.Add("Le moment d'inertie d'un objet dépend de sa masse et de la manière dont cette masse est distribuée par rapport à un axe de rotation.");
        myStringList.Add("Dans un système isolé, l'énergie mécanique (c'est-à-dire la somme de l'énergie cinétique et de l'énergie potentielle) est toujours conservée.");
        myStringList.Add("Les lois de Newton sont fondamentales pour comprendre comment les objets se déplacent sous l'effet des forces. Elles sont appliquées dans de nombreux domaines de la science.");
        myStringList.Add("La notion de travail en mécanique du point est liée à la force exercée pour déplacer un objet sur une certaine distance.");
        myStringList.Add("Un objet qui tourne autour d'un axe peut avoir une énergie cinétique rotatoire, qui dépend de son moment d'inertie et de sa vitesse angulaire.");
        myStringList.Add("La trajectoire d'un objet en mouvement peut être affectée par des forces externes comme la friction ou la résistance de l'air.");
        myStringList.Add("Le principe d'action et de réaction stipule que pour chaque force exercée, il existe une force opposée de même intensité mais de direction opposée.");
        myStringList.Add("Dans un mouvement rectiligne uniforme (MRU), un objet se déplace à vitesse constante, ce qui signifie qu'il parcourt la même distance chaque seconde.");
        myStringList.Add("Le calcul de la vitesse instantanée d'un objet peut être effectué à l'aide de la dérivée de sa fonction de position par rapport au temps.");
        myStringList.Add("La notion de force est cruciale en mécanique du point. Elle est responsable du changement de mouvement d'un objet, ou de sa déformation.");
        myStringList.Add("La force centripète est la force qui maintient un objet en mouvement circulaire, en l'orientant constamment vers le centre de sa trajectoire.");
        myStringList.Add("L'énergie potentielle est l'énergie qu'un objet possède en raison de sa position dans un champ de force, comme le champ gravitationnel de la Terre.");
        myStringList.Add("Lorsqu'un objet effectue un mouvement oscillatoire, comme un pendule, sa position et sa vitesse varient de manière périodique.");
        // Thème : Amour
        myStringList.Add("Le coeur humain bat plus fort quand il voit quelqu'un qu'il aime, c'est comme une petite fête dans ton corps!");
        myStringList.Add("Les éléphants montrent leur amour en se frottant les oreilles et en se tenant par la trompe. Trop mignon, non?");
        myStringList.Add("Les dauphins s'entraident et forment des liens très forts entre eux. Ils peuvent même adopter des 'enfants'!");
        myStringList.Add("Le terme 'coup de foudre' vient du fait qu'une personne peut tomber amoureuse instantanément, comme un éclair qui frappe!");
        myStringList.Add("Les pingouins mâles offrent des pierres aux femelles pour montrer leur amour. C'est un peu leur version de la demande en mariage!");
        myStringList.Add("Chez certains oiseaux, comme les geais bleus, les couples restent ensemble pour la vie. L'amour, c'est une affaire de long terme!");
        myStringList.Add("Les humains ont un 'hormone de l'amour', appelée ocytocine, qui est libérée lorsqu'ils se font un câlin ou qu'ils se tiennent la main.");
        myStringList.Add("Les fleurs peuvent exprimer l'amour aussi! Par exemple, les roses rouges symbolisent l'amour passionné.");
        myStringList.Add("Chez les guépards, les mâles doivent prouver leur amour en courant vite, pour montrer qu'ils peuvent protéger leurs partenaires!");
        myStringList.Add("Les pandas géants, bien que souvent solitaires, trouvent l'amour avec des partenaires spécifiques pendant la saison des amours.");
        myStringList.Add("Le baiser est un moyen pour les humains de se connecter. Il libère des endorphines, qui te font te sentir heureux et aimé!");
        myStringList.Add("Le coeur de certaines personnes bat au même rythme lorsqu'elles sont proches de leur amour. C'est comme si elles devenaient une seule personne!");
        myStringList.Add("Les baleines à bosse chantent de magnifiques chansons pendant la saison des amours pour attirer un partenaire.");
        myStringList.Add("Les hiboux sont des oiseaux amoureux et souvent, les couples restent ensemble pour toute la vie. C'est très romantique!");
        myStringList.Add("Les chiens montrent leur amour en remuant la queue et en restant proches de leurs maîtres. Leur fidélité est infinie.");
        myStringList.Add("Dans le monde des abeilles, la reine est le centre de l'amour du rucher. Les mâles s'unissent avec elle pour créer de nouveaux membres!");
        myStringList.Add("Les flamants roses, pour se montrer leur amour, dansent ensemble en effectuant des mouvements gracieux avec leur tête.");
        myStringList.Add("Les papillons migrateurs voyagent sur de longues distances, parfois pour retrouver un partenaire. L'amour peut voyager loin!");
        myStringList.Add("Les coeurs humains ont une énergie spéciale qui peut attirer et connecter deux personnes de manière magique, souvent sans qu'elles le sachent!");
        myStringList.Add("Les chats montrent aussi leur affection en frottant leur tête contre toi. C'est un gros câlin de leur part!");
        myStringList.Add("Les grenouilles peuvent chanter pour attirer un partenaire. Leur chant est leur façon de dire : 'Je t'aime!'");
        myStringList.Add("L'amour peut rendre une personne plus forte! On dit que l'amour donne des ailes, mais en réalité, il aide aussi à se sentir plus courageux!");
        myStringList.Add("Les dauphins sont des animaux très sociaux et ils s'aident souvent entre eux, ce qui montre l'importance des liens d'amitié et d'amour.");
        myStringList.Add("Certaines espèces d'araignées se donnent des cadeaux avant de se marier! Par exemple, la mâle offre un morceau de nourriture à la femelle.");
        myStringList.Add("Les chevaux montrent leur affection en se couchant ensemble ou en se frottant les têtes. Cela signifie qu'ils s'aiment et se respectent!");
        myStringList.Add("Les licornes sont des créatures mythiques, mais si elles existaient, on pourrait imaginer qu'elles seraient des symboles de l'amour pur et magique.");
        myStringList.Add("Chez les loups, les couples forment des liens très forts et chassent ensemble pour nourrir leur meute. L'amour dans la nature, c'est aussi l'entraide!");
        myStringList.Add("Les gibbons, ces petits singes, forment des couples monogames pour la vie, prouvant que l'amour peut durer toute une vie!");
        myStringList.Add("Les papillons de nuit, bien que très différents des autres papillons, volent souvent vers la lumière, un peu comme si l'amour les attirait vers elle.");
        // Thème : Cinéma
        myStringList.Add("Le premier film de l'histoire du cinéma, appelé 'La sortie des usines Lumière', a été projeté en 1895!");
        myStringList.Add("Les dinosaures dans 'Jurassic Park' étaient en réalité créés par ordinateur, mais on les voit si bien qu'on dirait qu'ils sont réels!");
        myStringList.Add("Dans le film 'Toy Story', les personnages sont tous animés par des ordinateurs, mais ils ressemblent tellement à des jouets qu'on pourrait les croire vrais!");
        myStringList.Add("Le film le plus long de l'histoire du cinéma est 'Logistics', qui dure... 35 jours entiers!");
        myStringList.Add("Dans le film 'Star Wars', le bruit du sabre laser a été créé en combinant le son d'un projecteur de film et celui d'un moteur d'antenne!");
        myStringList.Add("La célèbre phrase 'Que la force soit avec toi' de Star Wars est maintenant l'une des plus connues au monde!");
        myStringList.Add("Le film d'animation 'Le Roi Lion' a été inspiré par une tragédie grecque appelée 'Hamlet'. Qui l'eût cru?");
        myStringList.Add("Le film 'Titanic' a coûté tellement cher qu'il a fallu plusieurs années pour tout récupérer, mais il est devenu l'un des plus grands succès de tous les temps!");
        myStringList.Add("Le film 'Avatar' de James Cameron a révolutionné le cinéma en 3D, et les effets spéciaux sont tellement impressionnants qu'on dirait une autre planète!");
        myStringList.Add("Le film 'Forrest Gump' nous a donné la célèbre phrase 'La vie, c'est comme une boîte de chocolats'. Qui ne l'a pas entendue?");
        myStringList.Add("Dans 'Le Magicien d'Oz', les chaussures rouges de Dorothy étaient en réalité argentées dans le livre original!");
        myStringList.Add("Les acteurs du film 'Les Gardiens de la Galaxie' ont dû passer par un entraînement physique intense pour incarner leurs super-héros!");
        myStringList.Add("Le film 'E.T. l'extra-terrestre' a été un énorme succès, mais saviez-vous que le film a été tourné sans que l'on voit jamais les pieds de l'extraterrestre?");
        myStringList.Add("Dans 'La Reine des Neiges', les créateurs ont dû recréer de vrais paysages enneigés pour que tout semble aussi magique et réaliste!");
        myStringList.Add("Les effets spéciaux dans 'Inception' ont utilisé des techniques incroyables pour créer des mondes qui se plient et se tordent, c'est un vrai chef-d'oeuvre de cinéma!");
        myStringList.Add("Le film 'Les Dents de la mer' de Steven Spielberg a été tellement effrayant que des spectateurs ont eu peur d'aller à la plage après sa sortie!");
        myStringList.Add("Le film 'La Guerre des Etoiles' a lancé une révolution dans l'industrie du cinéma avec ses effets spéciaux et son univers incroyable.");
        myStringList.Add("Le film 'Avatar' a été le premier film à atteindre les 2 milliards de dollars au box-office mondial!");
        myStringList.Add("Les films de super-héros sont aujourd'hui très populaires, mais avant 2000, très peu de films de ce genre avaient du succès!");
        myStringList.Add("Les sons des films sont souvent créés par des experts en 'effets sonores'. Par exemple, le bruit des pas sur la neige dans un film est en fait créé avec du sel!");
        myStringList.Add("Dans 'Le Seigneur des Anneaux', les acteurs ont dû porter des chaussures spéciales pour qu'ils ressemblent à des hobbits de petite taille!");
        myStringList.Add("Le film 'Shrek' a été le premier film d'animation à remporter un Oscar du meilleur film d'animation en 2002.");
        myStringList.Add("Le personnage de James Bond a été inspiré par un véritable espion, et le nom 'Bond' a été choisi parce que c'était simple et mémorable!");
        myStringList.Add("Le film 'Avatar' a utilisé la technologie de capture de mouvement pour rendre les personnages extraterrestres encore plus réels!");
        myStringList.Add("Saviez-vous que les films d'animation comme 'Coco' utilisent des milliers d'images pour créer chaque scène? Chaque image est comme une peinture!");
        myStringList.Add("Les films de Tim Burton, comme 'Charlie et la chocolaterie', ont des décors et des costumes super créatifs qui créent des mondes magiques!");
        myStringList.Add("Les films d'animation de Pixar utilisent souvent des détails cachés, comme des clins d'oeil à d'autres films, que les spectateurs aiment découvrir!");
        myStringList.Add("Le film 'Harry Potter à l'école des sorciers' a transformé l'univers des films fantastiques et a fait rêver des millions de jeunes!");
        // Thème : Programmation informatique
        myStringList.Add("La première ligne de code informatique a été écrite en 1843 par Ada Lovelace, une mathématicienne pionnière!");
        myStringList.Add("En programmation, un 'bug' n'est pas un insecte, mais un problème dans un programme. Le terme vient d'un incident avec un vrai insecte!");
        myStringList.Add("Les ordinateurs ne comprennent que deux chiffres : 0 et 1. C'est ce qu'on appelle le 'langage binaire'!");
        myStringList.Add("Le mot 'software' (logiciel en anglais) a été inventé par un informaticien appelé John Tukey dans les années 1950!");
        myStringList.Add("Le premier virus informatique a été créé en 1986. Il s'appelait 'Brain', et c'était un virus bénin, mais il marquait le début des virus!");
        myStringList.Add("Les ordinateurs peuvent traiter des millions de calculs par seconde. Si un humain faisait cela, il faudrait des milliers d'années!");
        myStringList.Add("Le langage de programmation le plus populaire en 2024 est Python. C'est comme une baguette magique pour créer des programmes et des jeux!");
        myStringList.Add("Le terme 'hacker' a d'abord été utilisé dans les années 1960 pour désigner une personne qui trouvait des solutions créatives à des problèmes de programmation.");
        myStringList.Add("Le jeu vidéo 'Minecraft' a été créé par un seul développeur, Markus Persson, et est devenu l'un des jeux les plus populaires au monde!");
        myStringList.Add("Les algorithmes sont des séries d'étapes que les ordinateurs suivent pour résoudre des problèmes. C'est comme une recette de cuisine pour les programmes!");
        myStringList.Add("Le premier ordinateur électronique, appelé ENIAC, pesait 27 tonnes et mesurait la taille d'une pièce entière!");
        myStringList.Add("Le langage de programmation 'JavaScript' est utilisé pour rendre les sites web interactifs. C'est ce qui permet à tes jeux en ligne de fonctionner!");
        myStringList.Add("Dans les années 1960, un ordinateur prenait toute une pièce, alors qu'aujourd'hui, tu peux avoir des ordinateurs puissants dans la paume de ta main!");
        myStringList.Add("Le 'Hello, World!' est souvent la première ligne de code qu'un programmeur écrit. C'est une façon simple de dire que tout fonctionne!");
        myStringList.Add("La programmation informatique permet de créer non seulement des jeux vidéo, mais aussi des applications mobiles, des sites web, et même des robots!");
        myStringList.Add("Les robots que tu vois dans les films sont souvent contrôlés par des programmes informatiques très complexes qui leur permettent de bouger et de parler!");
        myStringList.Add("Le langage de programmation 'C' a été utilisé pour créer des systèmes d'exploitation comme Unix et est encore utilisé aujourd'hui!");
        myStringList.Add("En programmation, une 'fonction' est comme un petit programme à l'intérieur de ton programme. Elle fait une tâche spécifique, comme une mini-mission!");
        myStringList.Add("Les 'loops' (boucles) en programmation permettent de répéter une action encore et encore. C'est comme appuyer sur un bouton pour faire quelque chose plusieurs fois!");
        myStringList.Add("La programmation permet aussi de résoudre des problèmes complexes. Par exemple, elle peut aider à résoudre des équations mathématiques difficiles!");
        myStringList.Add("Un 'compilateur' est un programme qui transforme ton code écrit en langage humain en un code que l'ordinateur peut comprendre!");
        myStringList.Add("Le terme 'open source' désigne des programmes dont le code est disponible pour tous. Cela signifie que tout le monde peut l'améliorer!");
        myStringList.Add("Le jeu 'Tetris' a été créé en 1984 par un programmeur russe, Alexey Pajitnov, et il a été l'un des premiers jeux vidéo à devenir un phénomène mondial!");
        myStringList.Add("En 1969, le réseau informatique ARPANET a été créé, et c'est le précurseur d'Internet tel que nous le connaissons aujourd'hui!");
        myStringList.Add("Les programmeurs utilisent souvent des outils comme GitHub pour partager et collaborer sur leurs projets, un peu comme un atelier en ligne!");
        myStringList.Add("Le langage 'Scratch' a été conçu pour aider les enfants à apprendre la programmation de manière simple et amusante!");
        myStringList.Add("Le mot 'programmer' vient du mot latin 'programma', qui signifie 'plan ou projet'. C'est exactement ce que fait un programmeur : il crée un plan pour l'ordinateur!");
        myStringList.Add("En programmation, une 'variable' est comme une boîte dans laquelle tu mets des informations. Tu peux l'ouvrir et y mettre des nouvelles données à tout moment!");
        myStringList.Add("L'informatique est utilisée pour résoudre des problèmes de toutes sortes : de l'optimisation de trajets en voiture à la création de films d'animation!");
        myStringList.Add("Les jeux vidéo ne sont possibles que grâce à la programmation informatique. Les programmeurs écrivent le code qui fait fonctionner tous les jeux que tu aimes!");
        myStringList.Add("Les programmeurs utilisent des outils comme des débogueurs pour trouver et corriger les erreurs dans leur code. C'est un peu comme être un détective!");
        myStringList.Add("Il existe des millions de sites web dans le monde entier, et chacun d'eux est alimenté par des lignes de code qui font tout fonctionner!");
        // Thème : Histoires drôles
        myStringList.Add("Quel est le comble pour un électricien? De ne pas être au courant!");
        myStringList.Add("Que dit une étoile filante quand elle est pressée? 'Je file!'");
        myStringList.Add("Pourquoi les éléphants ont-ils peur des fourmis? Parce que ça chatouille leurs grandes oreilles!");
        myStringList.Add("Pourquoi les tomates sont-elles rouges? Parce qu'elles ont vu la salade se déshabiller!");
        myStringList.Add("Pourquoi les poissons détestent l'ordinateur? Parce qu'ils ont peur du net!");
        myStringList.Add("Pourquoi les squelettes ne se battent jamais entre eux? Parce qu'ils n'ont pas de tripes!");
        myStringList.Add("Quel est le comble pour un électricien? De ne pas être au courant!");
        // Thème : Jeux vidéo
        myStringList.Add("Le premier jeu vidéo commercialisé était Pong, un jeu de tennis créé en 1972. Un vrai classique!");
        myStringList.Add("Super Mario, l'un des personnages les plus célèbres du monde des jeux vidéo, a été créé par un designer japonais nommé Shigeru Miyamoto!");
        myStringList.Add("Le jeu vidéo le plus vendu de tous les temps est 'Minecraft'. En 2024, il s'est vendu à plus de 200 millions d'exemplaires!");
        myStringList.Add("Saviez-vous que le jeu 'Tetris' a été créé par un seul programmeur, Alexey Pajitnov, en 1984? Et c'est devenu un phénomène mondial!");
        myStringList.Add("Le premier jeu en 3D, 'Wolfenstein 3D', est sorti en 1992 et a ouvert la voie aux jeux de tir modernes!");
        myStringList.Add("Le jeu 'Fortnite' est devenu si populaire qu'il a même organisé un concert virtuel dans le jeu avec des stars comme Travis Scott!");
        myStringList.Add("Saviez-vous que dans 'The Legend of Zelda: Ocarina of Time', le personnage Link fait de la musique avec un instrument magique?");
        myStringList.Add("Le personnage de Sonic the Hedgehog a été conçu pour rivaliser avec Mario. Sonic court si vite qu'il peut même briser le son!");
        myStringList.Add("Le jeu 'Pong' était si simple qu'il n'avait même pas de sons. Aujourd'hui, les jeux vidéo ont des graphismes et des effets sonores incroyables!");
        myStringList.Add("Le personnage de Lara Croft dans 'Tomb Raider' a été un pionnier pour les personnages féminins dans les jeux d'aventure!");
        myStringList.Add("Le jeu 'Pac-Man' a été créé en 1980 et est devenu un symbole de la culture des jeux vidéo. Le but? Manger des points tout en évitant des fantômes!");
        myStringList.Add("Saviez-vous que le jeu 'Pokémon Go' a été l'un des premiers jeux mobiles à utiliser la réalité augmentée pour faire découvrir le monde réel aux joueurs?");
        myStringList.Add("Le jeu 'Minecraft' a tellement de fans qu'ils ont construit des répliques de véritables monuments, comme la Tour Eiffel et même des univers entiers!");
        myStringList.Add("Saviez-vous que 'Street Fighter II' a été l'un des premiers jeux à introduire des personnages avec des coups spéciaux? Il a révolutionné les jeux de combat!");
        myStringList.Add("Le jeu 'Overwatch' a tellement de personnages différents, chacun avec des pouvoirs uniques, que tu peux jouer de mille façons!");
        myStringList.Add("L'une des plus grandes compétitions de jeux vidéo, les 'eSports', consiste à jouer à des jeux comme 'League of Legends' ou 'Dota 2' devant des millions de spectateurs!");
        myStringList.Add("Le jeu 'Angry Birds' a été téléchargé plus de 3 milliards de fois! Un record impressionnant pour un simple jeu de lancer d'oiseaux!");
        myStringList.Add("Le jeu 'The Sims' permet aux joueurs de créer des personnages et de les contrôler comme dans la vie réelle. Certains créent même des villes entières!");
        myStringList.Add("Saviez-vous que 'Super Mario Bros.' a été le premier jeu à proposer un scrolling horizontal, ce qui permettait au personnage de se déplacer à gauche et à droite?");
        myStringList.Add("Le jeu 'Minecraft' a été tellement influent qu'il a été utilisé dans des écoles pour enseigner des matières comme les mathématiques et la géographie!");
        myStringList.Add("Le jeu 'Call of Duty' a été l'un des premiers jeux à introduire un mode multijoueur en ligne sur console, permettant aux joueurs de s'affronter à travers le monde!");
        myStringList.Add("Dans 'Super Mario 64', il y a une fameuse étoile secrète cachée dans chaque niveau. Les joueurs passent des heures à la chercher!");
        myStringList.Add("Le jeu 'Animal Crossing' est populaire pour sa nature détendue où tu construis ta propre ville et interagis avec des animaux. C'est un endroit relaxant!");
        myStringList.Add("Le jeu 'Final Fantasy' a des histoires et des personnages tellement détaillés que certains disent que c'est plus comme un film qu'un simple jeu!");
        myStringList.Add("Le premier jeu à proposer des graphismes en 3D, 'Super Mario 64', a changé la façon dont les jeux sont conçus à ce jour!");
        myStringList.Add("Le jeu 'Halo' a popularisé les jeux de tir à la première personne sur console. Il a été un immense succès dès sa sortie!");
        myStringList.Add("Saviez-vous que 'Tetris' a été utilisé par des astronautes dans l'espace pour les aider à se détendre et à se concentrer?");
        myStringList.Add("Saviez-vous que les jeux vidéo peuvent aussi être éducatifs? Par exemple, 'Brain Age' est un jeu qui aide à améliorer la mémoire et les capacités cérébrales!");
        myStringList.Add("Le jeu 'Zelda: Breath of the Wild' a ouvert un nouveau type de gameplay où tu peux explorer un monde ouvert et résoudre des énigmes!");
        myStringList.Add("Le jeu 'Minecraft' a créé un véritable mouvement où les joueurs partagent leurs créations en ligne et créent des histoires ensemble!");
        myStringList.Add("Le jeu 'Fortnite' a tellement marqué l'industrie qu'il a influencé des films et des concerts avec ses événements interactifs en ligne!");
        myStringList.Add("Le jeu 'Pac-Man' a été l'un des premiers à utiliser un système de score qui encourageait les joueurs à battre leurs propres records!");
        myStringList.Add("Saviez-vous que les créateurs de 'Portal' ont introduit un mécanisme de téléportation avec des portails pour résoudre des énigmes? Un vrai défi pour l'esprit!");
        myStringList.Add("Le jeu 'Minecraft' a tellement d'options de personnalisation que certains joueurs créent des mini-jeux et des mondes complets dans le jeu!");
        // Thème : Requins
        myStringList.Add("Saviez-vous que les requins existent depuis plus de 400 millions d'années? Ils étaient là bien avant les dinosaures!");
        myStringList.Add("Les requins n'ont pas d'os dans leur corps. Leur squelette est composé uniquement de cartilage, comme leur nez et leurs oreilles!");
        myStringList.Add("Le requin-baleine est le plus grand requin du monde, et il peut atteindre plus de 12 mètres de long, c'est plus grand qu'un autobus!");
        myStringList.Add("Le grand requin blanc peut nager à une vitesse de 56 km/h, ce qui en fait l'un des prédateurs marins les plus rapides!");
        myStringList.Add("Saviez-vous que les requins peuvent sentir une goutte de sang dans l'eau à des kilomètres de distance? Leur odorat est incroyable!");
        myStringList.Add("Les requins ont plusieurs rangées de dents qui se régénèrent constamment. Ils peuvent perdre des milliers de dents tout au long de leur vie!");
        myStringList.Add("Certains requins, comme le requin-baleine, mangent uniquement du plancton, des petits poissons et des algues. Ce sont des 'géants gentils'!");
        myStringList.Add("Les requins peuvent vivre jusqu'à 30 ans, mais cela varie selon les espèces. Le requin du Groenland peut vivre jusqu'à 400 ans, ce qui en fait l'un des animaux les plus vieux!");
        myStringList.Add("Le requin marteau a une tête en forme de marteau qui l'aide à voir mieux grâce à ses yeux placés de chaque côté. C'est une forme unique!");
        myStringList.Add("Il existe environ 500 espèces de requins, allant du petit requin pygmée de 17 cm au gigantesque requin-baleine de 12 mètres!");
        myStringList.Add("Les requins ont un sens du toucher très développé, grâce à des récepteurs spéciaux dans leur peau appelés ampoules de Lorenzini!");
        myStringList.Add("Les requins-marteaux peuvent détecter les champs électriques produits par leurs proies, ce qui les aide à chasser dans des eaux profondes et sombres!");
        myStringList.Add("Le requin-tigre a une grande réputation de prédateur, mais il est aussi très curieux et peut s'approcher des bateaux et des plongeurs!");
        myStringList.Add("Les requins ont besoin de nager constamment pour respirer, car l'eau passe par leurs branchies pendant qu'ils nagent!");
        myStringList.Add("Le requin-zèbre est une espèce très rare qui a des rayures sur son corps, un peu comme un zèbre, mais c'est un requin de petite taille!");
        myStringList.Add("Les requins-pèlerins mangent des petits poissons et des planctons. Ils sont incroyablement calmes et inoffensifs pour l'homme!");
        myStringList.Add("Le requin blanc peut détecter les mouvements de ses proies à 1,5 km de distance grâce à ses extraordinaires capacités sensorielles!");
        myStringList.Add("Les requins sont de très bons nageurs et peuvent plonger à plus de 1 000 mètres de profondeur pour chasser leurs proies!");
        myStringList.Add("Saviez-vous que le requin-marteau a un champ de vision beaucoup plus large que la plupart des autres requins, grâce à sa tête plate?");
        myStringList.Add("Les requins ont des yeux très particuliers. Leur rétine est conçue pour détecter même la plus faible lumière dans les profondeurs de l'océan!");
        myStringList.Add("Les requins sont essentiels pour l'équilibre des océans car ils sont au sommet de la chaîne alimentaire. Ils aident à contrôler les populations de poissons!");
        myStringList.Add("Saviez-vous que le requin de Ganges est l'un des rares requins d'eau douce, vivant dans les rivières de l'Inde et du Bangladesh?");
        myStringList.Add("Le requin-ange, une petite espèce, se cache souvent dans des cavernes sous-marines et se nourrit de petits poissons et de crustacés!");
        myStringList.Add("Le requin-baleine est si grand qu'il peut manger 21 tonnes de plancton en une seule journée! C'est un véritable géant pacifique!");
        myStringList.Add("Les requins sont connus pour leur incroyable sens de l'orientation. Ils peuvent parcourir de très longues distances grâce à des magnétites dans leur cerveau!");
        myStringList.Add("Les requins ont une très bonne mémoire et peuvent se souvenir de leur environnement pendant des années, ce qui les aide à retrouver leur nourriture!");
        myStringList.Add("Saviez-vous que certaines espèces de requins peuvent s'accoupler en restant côte à côte, tout en nageant dans des mouvements synchronisés?");
        myStringList.Add("Les requins ne peuvent pas respirer sans nager, car l'eau doit passer sur leurs branchies pour qu'ils puissent oxygéner leur sang!");
        myStringList.Add("Le requin-marteau se distingue par sa tête en forme de T, et il utilise cette forme pour repérer ses proies dans des endroits sombres!");
        myStringList.Add("Le requin-bleu est l'un des plus beaux requins, avec une couleur bleue brillante, mais c'est aussi un prédateur rapide et agile!");
        // Thème : Exploits sportifs
        myStringList.Add("Le record du monde du plus grand nombre de buts marqués en un seul match de football est de 149 buts: ça s'est passé en 2002!");
        myStringList.Add("Usain Bolt détient toujours le record du monde du 100 mètres avec un incroyable temps de 9,58 secondes, c'est plus rapide qu'une voiture de course!");
        myStringList.Add("Le joueur de tennis Roger Federer a remporté 20 titres du Grand Chelem, un exploit qui fait de lui l'un des meilleurs joueurs de tous les temps!");
        myStringList.Add("Le saut à la perche est un sport impressionnant. Le record du monde est de 6,18 mètres, ce qui est plus haut qu'un immeuble de 2 étages!");
        myStringList.Add("Le plus long match de tennis de l'histoire a duré 11 heures et 5 minutes et a eu lieu à Wimbledon en 2010 entre John Isner et Nicolas Mahut!");
        myStringList.Add("Michael Phelps, le nageur américain, détient le record de 23 médailles d'or olympiques, un exploit incroyable qui a fait de lui une légende!");
        myStringList.Add("Le joueur de basketball LeBron James a été sélectionné 19 fois pour le All-Star Game et a remporté 4 titres NBA, un exploit dans le monde du sport!");
        myStringList.Add("La plus longue course de vélo jamais réalisée a duré 5 ans! En 1928, un homme a parcouru 23 000 kilomètres pour faire le tour du monde à vélo!");
        myStringList.Add("La plus longue période sans perdre un match de tennis est détenue par Novak Djokovic, qui a remporté 43 matchs consécutifs en 2015!");
        myStringList.Add("En 1969, la gymnastique a vu une prouesse incroyable lorsque Nadia Comăneci a obtenu la première note parfaite de 10 aux Jeux Olympiques!");
        myStringList.Add("Le plus grand nombre de buts en un match de football a été marqué par un joueur en 1942 : il a inscrit 12 buts en une seule rencontre!");
        myStringList.Add("Le plus grand exploit en course de fond est détenu par Eliud Kipchoge, qui a couru un marathon en moins de 2 heures. Il a terminé en 1h59m40s!");
        myStringList.Add("En 1999, les Etats-Unis ont remporté la Coupe du Monde de football féminin, un exploit marquant dans l'histoire du sport!");
        myStringList.Add("Le record du monde de la plus grande distance parcourue en ski est de 17 000 kilomètres. Il a été réalisé lors d'un tour du monde en ski!");
        myStringList.Add("La plus grande course de relais à travers l'océan Atlantique a impliqué 1000 personnes en 2014. Cela a pris 4 jours et a couvert une distance de plus de 3000 km!");
        myStringList.Add("Le record du plus grand nombre de buts marqués dans l'histoire du football professionnel est détenu par Josef Bican, avec plus de 800 buts!");
        myStringList.Add("Le match de football le plus long de l'histoire a duré 3 heures et 48 minutes. Cela s'est produit lors d'un match d'Argentine en 1971!");
        myStringList.Add("Le plus grand nombre de buts marqués en une seule saison de football est de 91, un exploit réalisé par Lionel Messi en 2012!");
        myStringList.Add("Le plus grand saut en hauteur jamais enregistré par un humain est de 2,45 mètres. Cela a été réalisé en 1993 par l'athlète cubain Javier Sotomayor!");
        myStringList.Add("La plus longue traversée de l'Atlantique à la rame a été réalisée en 2015 et a duré 54 jours. L'équipe a traversé 5 000 km sans moteur!");
        myStringList.Add("Le plus grand nombre de buts marqués en une seule Coupe du Monde de football est de 13, réalisé par Just Fontaine en 1958!");
        myStringList.Add("Le record du monde de la plus grande distance parcourue en course à pied sans s'arrêter est de 564,5 kilomètres. Il a été réalisé en 2005!");
        myStringList.Add("En 2007, un sportif a sauté à 8,95 mètres en longueur, battant un vieux record de 8,90 mètres et devenant ainsi le meilleur dans cette discipline!");
        myStringList.Add("Le plus grand nombre de paniers à 3 points réalisés en NBA est de 4023, un exploit réalisé par Ray Allen, une légende du basket!");
        myStringList.Add("Le plus grand nombre de buts marqués dans un match de basket-ball a été de 100 points, un exploit réalisé par Wilt Chamberlain en 1962!");
        myStringList.Add("Le premier athlète à courir un marathon en moins de 2 heures était Eliud Kipchoge. Il a franchi la ligne d'arrivée en 1h59m40s en 2019!");
        myStringList.Add("Le plus grand nombre de tours de piste réalisés dans un marathon est de 105, c'est ce qu'un coureur a réalisé lors d'un marathon à New York!");
        // Thème : Capitales du monde
        myStringList.Add("La capitale du Japon est Tokyo, une ville qui est aussi l'une des plus peuplées au monde, avec plus de 37 millions d'habitants!");
        myStringList.Add("Saviez-vous que la capitale de l'Australie est Canberra et non Sydney? Beaucoup de gens pensent que c'est Sydney, mais c'est Canberra!");
        myStringList.Add("La capitale du Canada est Ottawa, une ville calme et pleine de verdure, située sur la rivière des Outaouais!");
        myStringList.Add("La capitale de la France est Paris, connue sous le nom de 'Ville Lumière', car elle a été l'une des premières villes à s'éclairer à l'électricité!");
        myStringList.Add("Brasilia est la capitale du Brésil et a été conçue pour être une ville moderne et bien planifiée. Elle a été inaugurée en 1960!");
        myStringList.Add("Le Caire, en Egypte, est la plus grande ville arabe du monde. C'est également la porte d'entrée vers les pyramides et les mystères de l'Antiquité!");
        myStringList.Add("La capitale de l'Inde est New Delhi, mais la ville principale du pays est Old Delhi, qui est beaucoup plus ancienne et historique!");
        myStringList.Add("La capitale de l'Italie est Rome, une ville légendaire où l'on peut encore admirer des vestiges de l'Empire romain comme le Colisée!");
        myStringList.Add("La capitale de la Russie est Moscou, et le Kremlin, qui est son centre politique, est l'un des lieux les plus célèbres du pays!");
        myStringList.Add("Le Pérou a pour capitale Lima, une ville située en bord de mer, offrant de superbes vues sur l'océan Pacifique!");
        myStringList.Add("L'Argentine a pour capitale Buenos Aires, une ville animée avec des influences européennes, et un important centre culturel et artistique!");
        myStringList.Add("La capitale de l'Afrique du Sud est Pretoria, mais le pays a aussi d'autres capitales pour le gouvernement et la législation!");
        myStringList.Add("La capitale de la Chine est Pékin, une ville impressionnante avec des monuments historiques comme la Cité Interdite et la Grande Muraille!");
        myStringList.Add("La capitale du Mexique est Mexico, une immense métropole avec une histoire fascinante, ancienne et moderne, en plein coeur de l'Amérique du Nord!");
        myStringList.Add("La capitale de l'Espagne est Madrid, une ville dynamique et colorée, connue pour ses musées comme le Prado et son équipe de football légendaire!");
        myStringList.Add("La capitale du Royaume-Uni est Londres, une ville remplie de monuments emblématiques comme le Big Ben et Buckingham Palace!");
        myStringList.Add("La capitale de l'Islande est Reykjavik, la capitale la plus au nord du monde, où il fait très froid, mais avec des sources chaudes!");
        myStringList.Add("La capitale de la Suède est Stockholm, une ville magnifique construite sur 14 îles, avec un grand nombre de ponts et de musées!");
        myStringList.Add("La capitale de la Finlande est Helsinki, une ville moderne et futuriste, où l'on trouve de nombreux espaces verts et des plages!");
        myStringList.Add("La capitale de la Belgique est Bruxelles, une ville cosmopolite qui abrite de nombreuses institutions internationales, dont l'Union européenne!");
        myStringList.Add("La capitale du Vietnam est Hanoï, une ville vibrante, avec une histoire riche, des temples et des lacs tranquilles au milieu de la ville!");
        myStringList.Add("La capitale de l'Argentine est Buenos Aires, connue pour ses danses de tango et ses délicieux steaks grillés!");
        myStringList.Add("La capitale de la Turquie est Ankara, bien que la ville d'Istanbul soit souvent plus célèbre, Ankara est le coeur administratif du pays!");
        myStringList.Add("La capitale du Maroc est Rabat, une ville paisible et charmante, située sur la côte atlantique du pays!");
        myStringList.Add("La capitale de la Corée du Sud est Séoul, une ville à la pointe de la technologie avec de grands centres commerciaux et des palais historiques!");
        myStringList.Add("La capitale de l'Egypte est Le Caire, une ville pleine d'histoire et de mystères, comme les pyramides de Gizeh et le sphinx!");
        myStringList.Add("La capitale de la Thaïlande est Bangkok, une ville connue pour ses temples magnifiques et sa vie nocturne trépidante!");
        myStringList.Add("La capitale du Japon, Tokyo, abrite la célèbre tour de Tokyo, qui ressemble à la Tour Eiffel et offre une vue incroyable sur la ville!");
        myStringList.Add("La capitale du Bangladesh est Dacca, une ville pleine de vie, mais aussi d'histoire et de traditions anciennes!");
        myStringList.Add("La capitale du Chili est Santiago, une ville entourée de montagnes et dotée de nombreux parcs et musées intéressants!");
        // Choisir un index alatoire pour retourner une chaîne de la liste
        // Thème : Architecture
        myStringList.Add("La tour Eiffel à Paris a été construite en 1889 pour l'Exposition Universelle, et elle était censée être démontée après 20 ans!");
        myStringList.Add("Le Colisée à Rome pouvait accueillir jusqu'à 50 000 spectateurs pour regarder des combats de gladiateurs et d'autres spectacles!");
        myStringList.Add("La grande pyramide de Gizeh en Egypte a été construite il y a plus de 4 500 ans et c'est le seul des sept merveilles du monde antique encore debout!");
        myStringList.Add("Le Taj Mahal en Inde est un magnifique mausolée de marbre blanc, construit par un empereur pour honorer sa femme décédée!");
        myStringList.Add("La Sagrada Familia à Barcelone, conçue par Antoni Gaudi, est en construction depuis 1882 et n'est toujours pas terminée!");
        myStringList.Add("Le Burj Khalifa à Dubaï est l'édifice le plus haut du monde, mesurant 828 mètres, soit plus de 2 fois la hauteur de la Tour Eiffel!");
        myStringList.Add("Le Pont du Golden Gate à San Francisco est l'un des ponts les plus photographiés au monde, avec sa couleur rouge vif distincte!");
        myStringList.Add("Le Parthénon en Grèce est un temple ancien construit en l'honneur de la déesse Athéna, et il est un symbole de l'architecture classique!");
        myStringList.Add("La Cité Interdite à Pékin était autrefois la résidence des empereurs chinois et comporte plus de 9000 pièces!");
        myStringList.Add("La maison de Frank Lloyd Wright, appelée la 'Maison sur la cascade', est un exemple étonnant d'architecture intégrée à la nature, avec une maison construite au-dessus d'une rivière!");
        myStringList.Add("Le Christ Rédempteur au Brésil est une immense statue de Jésus qui se trouve au sommet du mont Corcovado et domine Rio de Janeiro!");
        myStringList.Add("Le Panthéon à Rome est un ancien temple romain dont le dôme est toujours le plus grand dôme en béton non armé au monde!");
        myStringList.Add("Le Château de Neuschwanstein en Allemagne, avec ses tours féeriques, a inspiré le château de la Belle au bois dormant dans les films Disney!");
        myStringList.Add("Le Big Ben à Londres n'est pas le nom de la tour, mais celui de la grande cloche à l'intérieur de la tour!");
        myStringList.Add("La tour de Pise en Italie est célèbre pour son inclinaison, mais saviez-vous qu'elle penche d'environ 4 degrés, soit l'inclinaison d'un angle de 7,4 mètres?");
        myStringList.Add("La cathédrale de Notre-Dame à Paris a été construite pendant plus de 200 ans, et elle reste un chef-d'œuvre du gothique français!");
        myStringList.Add("La Muraille de Chine est un réseau de fortifications s'étendant sur plus de 21 000 kilomètres, ce qui en fait la plus longue structure humaine au monde!");
        myStringList.Add("La bibliothèque de l'université d'Harvard, aux Etats-Unis, possède une collection de plus de 20 millions de livres, faisant d'elle l'une des plus grandes au monde!");
        myStringList.Add("La place Tiananmen à Pékin est l'une des plus grandes places publiques du monde, avec une superficie de 44 hectares!");
        myStringList.Add("Le Palais de Versailles, en France, était la résidence des rois de France et est célèbre pour ses jardins et son opulence!");
        myStringList.Add("Le Sydney Opera House en Australie est un exemple d'architecture moderne, et ses voiles emblématiques sont l'une des structures les plus reconnaissables au monde!");
        myStringList.Add("L'Empire State Building à New York a été le plus haut gratte-ciel du monde pendant 40 ans, jusqu'à ce que le World Trade Center soit terminé en 1970!");
        myStringList.Add("Le Louvre à Paris, autrefois un palais royal, est aujourd'hui le plus grand musée d'art du monde, avec plus de 35 000 œuvres d'art!");
        myStringList.Add("La Basilique Saint-Pierre au Vatican est l'une des églises les plus grandes et les plus célèbres du monde, avec un impressionnant dôme conçu par Michel-Ange!");
        myStringList.Add("Le Château de Chambord en France est un exemple parfait de la Renaissance française, et sa double hélice d'escalier est un élément architectural unique!");
        myStringList.Add("Le Mont Rushmore aux Etats-Unis présente les visages de quatre présidents sculptés dans la montagne, et il a été inauguré en 1941!");
        myStringList.Add("La fontaine de Trevi à Rome est célèbre pour sa sculpture et pour la tradition de jeter une pièce en faisant un vœu pour revenir à Rome!");
        myStringList.Add("Le Palais des Nations à Genève, en Suisse, est le siège de l'Organisation des Nations Unies et possède une architecture moderne et imposante!");
        myStringList.Add("Le Château de Windsor en Angleterre est la plus ancienne résidence royale habitée au monde, datant du 11ème siècle!");
        myStringList.Add("Le Mont Saint-Michel en France est un îlot rocheux avec un abbaye médiévale qui semble flotter sur l'eau à marée haute!");
        // Thème : Révolution française
        myStringList.Add("La Révolution française a commencé en 1789 et a duré 10 ans, marquant un tournant dans l'histoire de la France et du monde!");
        myStringList.Add("Le fameux 'Bastille' était une prison à Paris, et son attaque le 14 juillet 1789 symbolise le début de la Révolution française!");
        myStringList.Add("Marie-Antoinette, la reine de France, est célèbre pour avoir dit, selon une légende, 'Qu'ils mangent de la brioche', mais il n'y a aucune preuve qu'elle ait vraiment dit cela!");
        myStringList.Add("Les citoyens parisiens ont envahi la Bastille non seulement pour libérer des prisonniers, mais aussi pour obtenir des armes, car ils étaient en colère contre la pénurie de nourriture!");
        myStringList.Add("Les Etats généraux de 1789 ont réuni les trois ordres de la société : le clergé, la noblesse et le tiers état (le peuple), mais ce dernier a formé l'Assemblée nationale pour défendre les droits du peuple!");
        myStringList.Add("Le 14 juillet est célébré comme la fête nationale en France, et c'est un jour où des feux d'artifice sont tirés en l'honneur de la prise de la Bastille!");
        myStringList.Add("Le slogan de la Révolution française était 'Liberté, égalité, fraternité', qui est encore le principe fondamental de la République française aujourd'hui!");
        myStringList.Add("Le roi Louis XVI a été exécuté en 1793 sur la place de la Révolution à Paris (aujourd'hui la place de la Concorde) par la guillotine!");
        myStringList.Add("La guillotine, inventée par le docteur Joseph-Ignace Guillotin, est devenue un symbole tristement célèbre de l'époque révolutionnaire pour les exécutions!");
        myStringList.Add("Napoléon Bonaparte, l'un des personnages les plus célèbres de la Révolution, a pris le pouvoir après la chute de la monarchie et a proclamé l'Empire en 1804!");
        myStringList.Add("La prise de la Bastille n'a pas seulement marqué le début de la Révolution, mais elle a aussi montré que le peuple pouvait renverser le pouvoir royal!");
        myStringList.Add("Robespierre, l'un des leaders de la Révolution, a joué un rôle clé pendant la Terreur, une période de violence extrême où des milliers de personnes furent exécutées!");
        myStringList.Add("Le calendrier révolutionnaire français a été adopté en 1793 et a remplacé les mois traditionnels par de nouveaux noms comme 'Fructidor' ou 'Vendémiaire'!");
        myStringList.Add("Le peuple français, lors de la Révolution, a pris des mesures extrêmes pour renverser la monarchie, mais aussi pour réorganiser la société et la politique!");
        myStringList.Add("Le 5 octobre 1789, des milliers de femmes se sont rendues à Versailles pour demander du pain, un événement marquant de la Révolution française!");
        myStringList.Add("La Déclaration des droits de l'homme et du citoyen, adoptée en 1789, a posé les bases des droits civils et humains en France et a inspiré le monde entier!");
        myStringList.Add("Le Comité de salut public, dirigé par Robespierre, a été chargé de défendre la Révolution contre ses ennemis, mais c'est aussi lui qui a entraîné de nombreuses exécutions!");
        myStringList.Add("Le 'Serment du Jeu de Paume' a été un événement historique majeur de la Révolution française, où les députés du Tiers Etat ont juré de ne pas se séparer avant d'avoir rédigé une constitution!");
        myStringList.Add("Le mouvement révolutionnaire a été inspiré par des idées des philosophes des Lumières, comme Rousseau, Voltaire et Montesquieu, qui ont remis en question le pouvoir absolu du roi!");
        myStringList.Add("Le 21 janvier 1793, Louis XVI a été exécuté, marquant la fin de la monarchie en France et le début d'une ère républicaine!");
        myStringList.Add("L'Assemblée nationale a créé la première constitution de la France en 1791, mais elle a échoué à empêcher l'ascension de Napoléon et à préserver la République!");
        myStringList.Add("Le général Lafayette, héros de la guerre d'indépendance des Etats-Unis, a joué un rôle important dans la Révolution française en soutenant le peuple contre la monarchie!");
        myStringList.Add("Le thermidorienne (1794) a mis fin à la période de la Terreur, marquée par une série d'exécutions et de répressions, et a conduit à l'arrestation de Robespierre!");
        myStringList.Add("La Révolution a inspiré de nombreuses révolutions dans le monde, notamment en Amérique latine, et a donné naissance à des idées républicaines et démocratiques!");
        myStringList.Add("Le 'panthéonisme', qui prônait une société sans distinctions de classes, a été un principe central de la Révolution française, même si sa mise en œuvre a été difficile!");
        
        
        int randomIndex = UnityEngine.Random.Range(0, myStringList.Count);


        // Retourner la chaîne au hasard
        return myStringList[randomIndex];
    }
}
