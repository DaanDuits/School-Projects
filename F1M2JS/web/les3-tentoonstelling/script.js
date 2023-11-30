const myImage = document.getElementById("myImage")
const myTitle = document.getElementById("myTitle")

let titles = [
    "De schilderijen van van Gogh",
    "De rode wijngaardDe rode wijngaard",
    "De sterrennacht",
    "Sterrennacht boven de Rhône",
    "Zonnebloemen",
    "Boerderij in de Provence"
];

function ChangeImage(index)
{
    myImage.src = "img/painting" + index + ".jpg";
    myTitle.innerHTML = titles[index]
}