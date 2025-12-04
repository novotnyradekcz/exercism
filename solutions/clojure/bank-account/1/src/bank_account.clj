(ns bank-account)

(defn- valid-account? [account]
  (and (map? @account) (:open? @account)))

(defn open-account []
  "Opens a new account. Returns an atom containing account details."
  (atom {:balance 0 :open? true}))

(defn close-account [account]
  "Closes the given account. Operations on a closed account should fail."
  (swap! account assoc :open? false))

(defn get-balance [account]
  "Gets the balance of the account. Returns nil if the account is closed."
  (if (valid-account? account)
    (:balance @account)
    nil))

(defn update-balance [account amount]
  "Updates the balance of the account by the given amount. Throws an error if the account is closed."
  (if (valid-account? account)
    (swap! account update :balance + amount)
    (throw (Exception. "Account is closed."))))
