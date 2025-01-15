namespace PsychologicalTestWithBlazor.Models
{
    public class PsychotypesInfo
    {
        public static Dictionary<string, string> Get()
        {
            return new Dictionary<string, string>()
            {
                {"Dysthymia (Persistent Depressive Disorder)",
                    "A chronic form of depression with less severe symptoms that last for a long time (at least two years). " +
                    "People can function but constantly feel a low mood. " +
                    "Recommendations: People with dysthymia benefit from regular physical exercise, maintaining a healthy lifestyle, and seeking " +
                    "social support. It is also important to explore self-help methods such as cognitive-behavioral therapy (CBT), which can " +
                    "help improve mood and learn to cope with negative thoughts."
                },
                {"Atypical Depression",
                    "A type of depression where mood may temporarily improve in response to positive events. Specific symptoms such as increased appetite and " +
                    "sleepiness may also be present." +
                    "Recommendations: Managing atypical depression is aided by therapy aimed at improving mood and managing specific symptoms like increased appetite and sleepiness. " +
                    "Discussing with a doctor about the possible use of antidepressants, which can help stabilize mood, might also be beneficial."
                },
                {"Seasonal Affective Disorder",
                    "A type of depression related to seasonal changes, most commonly starting in the fall and continuing through winter. Symptoms can be quite mild but, " +
                    "in some cases, severe." +
                    "Recommendations: An important approach for treating SAD is light therapy, which involves using special lamps that mimic natural sunlight. " +
                    "Maintaining a regular physical activity routine and spending time outdoors, even in winter, can also be beneficial."
                },
                {"Major Depression (Clinical Depression)",
                    "Intense symptoms of depression lasting at least two weeks. May include loss of interest in activities, significant weight loss or gain, " +
                    "insomnia or excessive sleepiness, feelings of hopelessness, and suicidal thoughts." +
                    "Recommendations: For people with major depression, it's important to seek professional help. A combination of psychotherapy and medication is usually recommended. " +
                    "Regular therapy and support from loved ones can significantly ease symptoms and aid in the recovery process."
                },
                {"Bipolar Disorder (Manic-Depressive Disorder)",
                    "Characterized by alternating episodes of depression and mania. Depressive episodes can be extremely severe and involve significant health and safety risks." +
                    "Recommendations: For people with bipolar disorder, following a regular treatment plan, which may include mood stabilizers and psychotherapy, is crucial. " +
                    "Regular monitoring of symptoms and avoiding stressful situations can help reduce the frequency and intensity of manic and depressive episodes."
                },
                {"Psychotic Depression",
                    "A severe form of depression in which psychotic symptoms, such as hallucinations and delusions, accompany the primary depressive symptoms. This form of depression requires " +
                    "immediate medical intervention." +
                    "Recommendations: Psychotic depression requires urgent medical intervention. Treatment typically involves a combination of antidepressants and antipsychotic medications. " +
                    "A doctor may also recommend hospitalization to ensure safety and effective treatment. Psychotherapy can be helpful as part of a long-term recovery plan."
                }
            };
        }
    }
}
