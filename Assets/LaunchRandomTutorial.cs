using UnityEngine;

public class LaunchRandomTutorial : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void StartRandomTutorial()
    {
        int choice = UnityEngine.Random.Range(0, 16);

        switch (choice) 
        {
            case 0: TextInitializerFJ.StartFJ(); break;
            case 1: TextInitializerFJGH.Startfjgh(); break;
            case 2: TextInitializerRTYU.Startrtyu(); break;
            case 3: TextInitializerCVBNvirgule.StartCVBN(); break;
            case 4: TextInitializer567.Start567(); break; // Changed from duplicate case 3
            case 5: TextInitializerKD.Startkd(); break;
            case 6: TextInitializerKDEI.Startkdei(); break;
            case 7: TextInitializerKDXpointvirgule.Startkdx(); break;
            case 8: TextInitializer4839.Start4839(); break;
            case 9: TextInitializerSL.Startsl(); break;
            case 10: TextInitializerSLZO.Startslzo(); break;
            case 11: TextInitializerSLWdeuxpoints.Startswdeuxpoints(); break;
            case 12: TextInitializeréà20.Startéà20(); break;
            case 13: TextInitializerqm.Startqm(); break;
            case 14: TextInitializerqmap.Startqmap(); break;
            case 15: TextInitializerqminfpointdexclamation.Startqminfexclam(); break;
            case 16: TextInitializer1rond.Start1rond(); break;
        }

        NewTutorialGame.StartTutorial();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
