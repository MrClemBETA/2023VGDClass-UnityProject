using UnityEngine;

namespace cherrydev
{
    [System.Serializable]
    public struct Sentence
    {
        public string characterName;
        public string text;
        public Sprite characterSprite;
        public AudioClip audioClip;

        public Sentence(string characterName, string text)
        {
            characterSprite = null;
            audioClip= null;
            this.characterName = characterName;
            this.text = text;
        }
    }
}