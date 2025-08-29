//var schedule = [];
//var list = document.getElementById("schedule");
//var button = document.getElementById("btn1");
// TODO: Create a function called downloadSchedule
//       Use an XMLHttpRequest to GET "/schedule/list"
//       The response will be a JSON object of the form "{ schedule: [ ... ] }"
//       Save the array into the schedule variable
//       Then call displaySchedule()
var request = new XMLHttpRequest();
var url = "http://localhost:55193/Courses.txt";

    request.onreadystatechange = function () {

        // Check if fetch request is done
        if (request.readyState == 4 && request.status == 200) {

            // Parse the JSON string
            var jsonData = JSON.parse(request.responseText);

            // Call the showArtists(), passing in the parsed JSON string
            showArtists(jsonData);
        }
    };
    

    // Do the HTTP call using the url variable we specified above
    request.open("GET", url, true);
    request.send();
    // Function that formats the string with HTML tags, then outputs the result
var output = "";
    function showArtists(data) {
      output = "<ul>"; // Open list
        var i;

        // Loop through the artists, and add them as list items
        for (var i in data.Courses) {
            output += "<li>" + data.Courses[i].CourseName + " (Price: " + data.Courses[i].Price + ")</li>";
        }

        output += "</ul>"; // Close list
        //document.getElementById("artistList").innerHTML = output;


}

function ShowResult() {
    document.getElementById("artistList").innerHTML = output;
}





   

//    request.onreadystatechange = function () {
//        if (request.readyState === 4) {
//            try {
//                var response = JSON.parse(request.responseText);
//                if (request.status === 200) {
//                    schedule = response.schedule;
//                    displaySchedule();
//                } else {
//                    alert(response.message);
//                }
//            } catch (exception) {
//                alert(exception.message)
//                alert("Schedule list not available.");
//            }
//        }
//    };
//    request.send();
//}

//function createSessionElement(data) {
//    var li = document.createElement("li");
//    li.innerHTML = data;
//    return li;
//};




//function displaySchedule() {
//    clearList();
//    for (var i = 0; i < schedule.length; i++) {
//            var li = createSessionElement(schedule[i]);
//            list.appendChild(li);
//        }
//}


//button.addEventListener("click", displaySchedule, false);
//downloadSchedule();