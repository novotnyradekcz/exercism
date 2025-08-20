#include "grade_school.h"

void init_roster(roster_t *roster)
{
    roster->count = 0;
}

bool is_student_in_roster(student_t student, roster_t *roster)
{
    for (size_t i = 0; i < roster->count; i++) {
        if (strcmp(roster->students[i].name, student.name) == 0) {
            return true;
        }
    }
    return false;
}

bool add_student(roster_t *roster, char *student, uint8_t grade)
{
    if (roster->count >= MAX_STUDENTS) {
        return false;
    }

    student_t new_student = { grade, "" };
    strncpy(new_student.name, student, MAX_NAME_LENGTH);
    new_student.name[MAX_NAME_LENGTH - 1] = '\0';

    if (is_student_in_roster(new_student, roster)) {
        return false;
    }

    roster->students[roster->count] = new_student;
    roster->count++;

    for (size_t i = 0; i < roster->count - 1; i++) {
        for (size_t j = i + 1; j < roster->count; j++) {
            if (roster->students[i].grade > roster->students[j].grade ||
                (roster->students[i].grade == roster->students[j].grade &&
                 strcmp(roster->students[i].name, roster->students[j].name) > 0)) {
                student_t temp = roster->students[i];
                roster->students[i] = roster->students[j];
                roster->students[j] = temp;
            }
        }
    }

    return true;
}

roster_t get_grade(roster_t *roster, uint8_t grade)
{
    roster_t result = { 0 };
    for (size_t i = 0; i < roster->count; i++) {
        if (roster->students[i].grade == grade) {
            add_student(&result, roster->students[i].name, grade);
        }
    }
    return result;
}