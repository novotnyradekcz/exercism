class HighScores:
    def __init__(self, scores):
        self.scores = scores
    def latest(self):
        return self.scores[-1]
    def personal_best(self):
        sorted_scores = self.scores.copy()
        sorted_scores.sort()
        return(sorted_scores[-1])
    def personal_top_three(self):
        sorted_scores = self.scores.copy()
        sorted_scores.sort()
        top_three = sorted_scores[-3:]
        top_three.reverse()
        return(top_three)
