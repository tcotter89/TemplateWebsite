$(function () {
    //Show All button to load all posts for a topic/thread
    //$(".ShowAll").click(function () {
    //    var button = $(".ShowAll");
    //    PopForums.LoadAllPosts(PopForums.currentTopicState.topicID, button);
    //});
    $(".post-reply").click(function () {
        $(".post-reply").fadeOut(500, function () {
            $('.new-post-container').fadeIn(500);
        });
    });
});