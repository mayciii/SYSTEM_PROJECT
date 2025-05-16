_# PSEUDOCODE
GROUP 4

MAIN PROGRAM
START
    CREATE main window titled "Smart Blood Donor Eligibility System"
    SET window size to 600x700
    CALL create_widgets()
    RUN main GUI loop
END
MAIN FUNCTION 

FUNCTION check_eligibility()
    GET name, age, weight, last_donation
    IF name is empty
        SHOW warning and EXIT

    VALIDATE age using validate_number()
    VALIDATE weight using validate_number()
    VALIDATE last donation date using validate_date()

    IF validation failed for age or weight
        EXIT FUNCTION

    SET is_eligible = True
    INITIALIZE reasons list = []

    IF age < 18 or age > 65
        is_eligible = False
        ADD reason

    IF weight < 50
        is_eligible = False
        ADD reason

    IF last_donation is valid
        IF days_since_donation < 56
            is_eligible = False
            ADD reason

    CHECK checkboxes:
        IF recent_surgery_var is True → ADD reason
        IF recent_tattoo_var is True → ADD reason
        IF pregnancy_var is True → ADD reason
        IF travel_var is True → ADD reason

    CHECK medical conditions for high-risk keywords like:
        ["hepatitis", "hiv", "aids", "cancer", "heart disease"]
        IF found → ADD reason

    CALL show_results(is_eligible, reasons)

END FUNCTION
IF user selects "Exit"
Close the program

