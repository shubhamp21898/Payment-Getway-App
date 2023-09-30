$(document).ready(function () {    
    showSelectedPlans("monthly");
    $(".switch-wrapper input").change(function () {
        const selectedPlan = $("input[name='switch']:checked").val();
        showSelectedPlans(selectedPlan);

        // Check if both buttons are checked and toggle accordingly
        if (selectedPlan === "monthly") {
            $(".yearly").hide();
            $(".monthly").show();
        } else if (selectedPlan === "yearly") {
            $(".monthly").hide();
            $(".yearly").show();
        }
    });
});


function showSelectedPlans(selectedPlan) {
    // Hide all plans initially
    $(".monthly").hide();

    // Show the selected plan
    $(`.${selectedPlan}`).show();
}
