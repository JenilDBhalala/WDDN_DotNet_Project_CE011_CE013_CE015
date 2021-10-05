function commentClicked(element) {
    var commentbox = document.getElementById("comment-box");
    // console.log(commentbox)
    // commentbox.style.visibility="hidden";
    commentbox.style.display = "block";
    console.log("comment");
}

function likeClicked(element) {
    var p = document.getElementById("like").getElementsByTagName("p")[0];
    if (element.className === "far fa-thumbs-up") {
        element.className = "fas fa-thumbs-up";
        element.style.color = "green";
        p.innerText = "Liked";
    }
    else {
        element.className = "far fa-thumbs-up";
        element.style.color = "";
        p.innerText = "Like";
    }
}
function cancelComment(subelement) {
    let commentBox = subelement.parentElement;
    commentBox.style.display = "none";
    console.log(commentBox);
}
