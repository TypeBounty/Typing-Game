using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LRWordGenerator : MonoBehaviour
{
	private static string wordList2 = "" +
        "#include<iostream>\n" +
        "using namespace std;" +
        "\n\n" +
        "int main()" +
        "{\n\n" +
        "\t" +
        "int i = 0;\n\n" +
        "\tcout << i << endl;\n\n" +
        "\ti = i + 1;\n\n" +
        "\tcout << i << endl;\n\n" +
        "\treturn(0);\n" +
        "}\n";

    private static string[] wordList = { "get", "out", "of", "my", "treehouse" };

    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];
        return randomWord;
    }

    public static string GetWordList()
    {
        return wordList2;
    }
}
