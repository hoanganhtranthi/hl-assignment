const apiUrl = 'https://localhost:7023/api/jokees';
const data = document.getElementById('jokes-description');
const emptyList = [];
function setCookie(cname, cvalue, exdays) {
    const d = new Date();
    d.setTime(d.getTime() + (exdays * 24 * 60 * 60 * 1000));
    let expires = "expires=" + d.toUTCString();
    document.cookie = cname + "=" + cvalue + ";" + expires + ";path=/";
}

function getCookie(cname) {
    let name = cname + "=";
    let decodedCookie = decodeURIComponent(document.cookie);
    let ca = decodedCookie.split(';');
    for (let i = 0; i < ca.length; i++) {
        let c = ca[i];
        while (c.charAt(0) == ' ') {
            c = c.substring(1);
        }
        if (c.indexOf(name) == 0) {
            return c.substring(name.length, c.length);
        }
    }
    return "";
}

function handleLike(id) {
    setCookie(id, "true", 1);
    location.reload();
}

function handleDislike(id) {
    setCookie(id, "false", 1);
    location.reload();
}

async function loadJoke() {
    const response = await fetch(apiUrl);
    const myJson = await response.json();
    myJson.forEach(item => {
        let user = getCookie(item.id);
        if (!user) {
            data.textContent = item.description;
            const likebtn = document.getElementById('likebtn');
            const dislikebtn = document.getElementById('dislikebtn');
            likebtn.onclick = () => handleLike(item.id);
            dislikebtn.onclick = () => handleDislike(item.id);
            return;
        }
        else emptyList.push(user);
    });
    if (myJson.length == emptyList.length) {
        alert("That's all the jokes for today! Come back another day!");
    }
}
