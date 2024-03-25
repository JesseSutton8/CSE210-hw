using System;

public class WritingAssignment : Assignment {

    private string _title;

    public WritingAssignment(string studentName, string topic, string title) 
    : base(studentName, topic) {
        SetStudentName(studentName);
        SetTopic(topic);
        _title = title;
    }

    public string GetWritingInfo() {
        return $"{GetSummary()} \n{_title}\n";
    }
}