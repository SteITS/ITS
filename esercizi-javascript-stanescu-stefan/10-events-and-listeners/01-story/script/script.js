const button = document.getElementById('gen-button');
button.addEventListener('click', makeStory);

function makeStory() {
    const noun = document.getElementById('noun').value;
    const adjective = document.getElementById('adjective').value;
    const person = document.getElementById('person').value;

    const story = `${person} really likes ${adjective} ${noun}.`;

    const storyDiv = document.getElementById('story');
    storyDiv.textContent = story;
    storyDiv.style.fontSize = '18px';
    storyDiv.style.color = 'purple';
    storyDiv.style.marginTop = '20px';
}
